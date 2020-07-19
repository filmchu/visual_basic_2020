Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนรหัส")
        If Username = "ชุติมา" And Password = "78910" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\chutima puttachanya\All_Images\All_Images\p8jzhx6gdLbKUmB309Y-o.jpg")
        ElseIf Username = "วันพีช" And Password = "78910" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\chutima puttachanya\All_Images\All_Images\ดาวน์โหลด (1).jpg")
        ElseIf Username = "เบลล่า" And Password = "78910" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\chutima puttachanya\All_Images\All_Images\oz1lgdcifSko5IJnyjS-o.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
