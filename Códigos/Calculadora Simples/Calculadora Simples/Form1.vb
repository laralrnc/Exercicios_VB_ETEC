Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim n1, n2, resu As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resu = n1 + n2
        TextBox3.Text = resu

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n1, n2, resu As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resu = n1 - n2
        TextBox6.Text = resu
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1, n2, resu As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resu = n1 * n2
        TextBox5.Text = resu
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n1, n2, resu As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resu = n1 / n2
        TextBox4.Text = resu
    End Sub
End Class
