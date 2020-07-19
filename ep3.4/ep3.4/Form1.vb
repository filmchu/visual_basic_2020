Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Dim FirstNum, SecondNum, SecondNum1, Result, Result1 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNum = TextBox1.Text
        SecondNum = TextBox2.Text
        SecondNum1 = TextBox4.Text
        Result = FirstNum * SecondNum
        Result1 = SecondNum1 - Result
        Label6.Text = Result
        Label7.Text = Result1
    End Sub
End Class
