Public Class Form1
    Dim FirstNum, SecondNum, Result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNum = TextBox1.Text
        SecondNum = TextBox2.Text
        If RadioButton1.Checked = True Then
            Result = FirstNum + SecondNum
        ElseIf RadioButton2.Checked = True Then
            Result = FirstNum - SecondNum
        ElseIf RadioButton3.Checked = True Then
            Result = FirstNum * SecondNum
        ElseIf RadioButton4.Checked = True Then
            Result = FirstNum / SecondNum
        ElseIf RadioButton5.Checked = True Then
            Result = FirstNum ^ SecondNum
        End If
        TextBox3.Text = Result
    End Sub
End Class
