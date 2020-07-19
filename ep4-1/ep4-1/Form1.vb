Public Class Form1
    Dim Point, Grade As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Point = TextBox1.Text
        If Point >= 80 Then
            Grade = "A"
        ElseIf Point >= "70" Then
            Grade = "B"
        ElseIf Point >= "60" Then
            Grade = "C"
        ElseIf Point >= "50" Then
            Grade = "D"
        Else
            Grade = "F"
        End If
        Label2.Text = Grade
    End Sub
End Class
