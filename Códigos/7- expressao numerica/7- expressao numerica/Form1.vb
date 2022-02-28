Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, r, s As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        r = (a + b) * 2
        s = (b + c) * a
        d = (r + s) / 4
        Label6.Text = d


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label6.Text = ""


    End Sub
End Class
