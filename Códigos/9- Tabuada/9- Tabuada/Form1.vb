Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1, resu1, resu2, resu3, resu4, resu5, resu6, resu7, resu8, resu9, resu10 As Double

        n1 = TextBox1.Text
        resu1 = n1 * 1
        resu2 = n1 * 2
        resu3 = n1 * 3
        resu4 = n1 * 4
        resu5 = n1 * 5
        resu6 = n1 * 6
        resu7 = n1 * 7
        resu8 = n1 * 8
        resu9 = n1 * 9
        resu10 = n1 * 10

        Label3.Text = resu1
        Label4.Text = resu2
        Label6.Text = resu3
        Label7.Text = resu4
        Label8.Text = resu5
        Label9.Text = resu6
        Label10.Text = resu7
        Label11.Text = resu8
        Label12.Text = resu9
        Label13.Text = resu10


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = ""
        Label4.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        TextBox1.Clear()

    End Sub
End Class
