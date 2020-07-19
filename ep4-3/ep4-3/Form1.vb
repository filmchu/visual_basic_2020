Public Class Form1
    Dim Price, Number, Total As Double
    Dim Stamp As Byte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Number = TextBox2.Text
        Total = Price * Number
        Stamp = Total / 50
        Label5.Text = Total
        Label6.Text = Stamp
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
