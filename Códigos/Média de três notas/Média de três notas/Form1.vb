Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, resu As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        resu = (n1 + n2 + n3) / 3
        Label7.Text = resu
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label7.Text = ""
       
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
