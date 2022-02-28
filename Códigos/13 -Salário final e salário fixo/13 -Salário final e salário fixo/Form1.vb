Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim salf, venm, salc As Double
        Dim nome As String
        nome = TextBox1.Text
        salf = TextBox2.Text
        venm = TextBox3.Text
        salc = (venm * 0.2) + salf
        Label10.Text = salc
        Label9.Text = salf
        Label8.Text = nome



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label10.Text = ""
        Label9.Text = ""
        Label8.Text = ""


    End Sub
End Class
