Public Class Form6
    Dim exer As New exer5

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        exer.val = Val(TextBox1.Text)
        exer.porcen = Val(TextBox2.Text)

        exer.calporcen()
        Label3.Text = exer.calporcen()
    End Sub


End Class