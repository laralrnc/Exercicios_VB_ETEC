Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim total, grl, boy, grlp, boyp As Double
        total = TextBox1.Text
        grl = TextBox2.Text
        boy = TextBox3.Text
        grlp = (100 * grl) / total
        boyp = (100 * boy) / total
        Label7.Text = grlp
        Label8.Text = boyp

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label7.Text = ""
        Label8.Text = ""
    End Sub
End Class
