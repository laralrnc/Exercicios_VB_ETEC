Public Class Form7
    Public exer As New exer6
    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exer.amigos = Val(TextBox1.Text)
        exer.balas = Val(TextBox2.Text)

        exer.calcab()

        Label3.Text = exer.calcab()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class