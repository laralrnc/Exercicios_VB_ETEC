Public Class Form1

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pc, pv, por As Double
        pc = TextBox1.Text
        por = TextBox2.Text
        pv = (pc * por) / 100
        Label5.Text = pv + pc


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label5.Text = ""

    End Sub
End Class
