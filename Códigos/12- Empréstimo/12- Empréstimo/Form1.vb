Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label10.Text = ""
        Label9.Text = ""

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ve, qp, ju, fi, vt As Double
        ve = TextBox1.Text
        qp = TextBox2.Text
        ju = TextBox3.Text
        fi = (ve / qp) + ju
        vt = fi * qp
        Label9.Text = fi
        Label10.Text = vt




    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
