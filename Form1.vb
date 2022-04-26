Public Class Form1
    Public p1, p2 As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("welcome to tic tac game by zaki")
        p1 = InputBox("Saisir name of player 1", "name of player 1")
        p2 = InputBox("Saisir name of player 2", "name of player 2")
        If p1 = "" Then
            p1 = "player 1"
            p2 = "player 2"
        End If
        Label1.Text = p1 + Label1.Text
        Label2.Text = p2 + Label2.Text
        Label3.Text = p1 + Label3.Text
        Label4.Text = p2 + Label4.Text
        Label2.Visible = False


    End Sub
    Public Sub chek()
        If Button1.Text = "x" And Button2.Text = "x" And Button3.Text = "x" Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False


        ElseIf (Button1.Text = "x" And Button5.Text = "x" And Button9.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "x" And Button4.Text = "x" And Button7.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button4.Text = "x" And Button5.Text = "x" And Button6.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button7.Text = "x" And Button8.Text = "x" And Button9.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button2.Text = "x" And Button5.Text = "x" And Button8.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "x" And Button6.Text = "x" And Button9.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "x" And Button5.Text = "x" And Button7.Text = "x") Then
            MsgBox("Congratulation " & p2 & "You Win", MsgBoxStyle.Information, "win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            'player 1



        ElseIf (Button1.Text = "o" And Button2.Text = "o" And Button3.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "o" And Button5.Text = "o" And Button9.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "o" And Button4.Text = "o" And Button7.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button4.Text = "o" And Button5.Text = "o" And Button6.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button7.Text = "o" And Button8.Text = "o" And Button9.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button2.Text = "o" And Button5.Text = "o" And Button8.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "o" And Button6.Text = "o" And Button9.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "o" And Button5.Text = "o" And Button7.Text = "o") Then
            MsgBox("Congratulation " & p1 & "You Win", MsgBoxStyle.Information, "win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Visible = True Then
            Button1.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button1.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Visible = True Then
            Button2.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button2.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Visible = True Then
            Button3.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button3.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Label1.Visible = True Then
            Button4.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button4.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Label1.Visible = True Then
            Button5.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button5.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Label1.Visible = True Then
            Button6.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button6.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Label1.Visible = True Then
            Button7.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button7.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Label1.Visible = True Then
            Button8.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button8.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Label1.Visible = True Then
            Button9.Text = "o"
            chek()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 500000
        End If
        If Label2.Visible = True Then
            Button9.Text = "x"
            chek()
            Label1.Visible = True
            Label2.Visible = False
        End If
500000: Button9.Enabled = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
    End Sub

End Class
