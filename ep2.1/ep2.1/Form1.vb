Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstname As String
        firstname = "chutima"
        Label1.Text = firstname
        firstname = "puttachanya"
        Label2.Text = firstname
        firstname = "film"
        Label3.Text = firstname
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อ"
        FullName = InputBox(Prompt)
        Label1.Text = FullName
        Prompt = "กรุณาป้อนนามสกุล"
        FullName = InputBox(Prompt)
        Label2.Text = FullName
        Prompt = "กรุณาป้อนชื่อเล่น"
        FullName = InputBox(Prompt)
        Label3.Text = FullName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "ชื่อและนามสกุลของคุณ")

    End Sub
End Class
