Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, x As Single
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        x = Val(TextBox3.Text)
        If Not (x > 5) Then
            c = (a + b) * x
        Else
            c = (a - b) * x
        End If
        MsgBox("resultado de c=" + Str(c))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class