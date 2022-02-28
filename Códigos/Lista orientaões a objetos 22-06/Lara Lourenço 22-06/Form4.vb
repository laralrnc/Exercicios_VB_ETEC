Public Class Form4
    Public resu As New exer3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        resu.idade = Val(TextBox1.Text)
        resu.calcidade()
        Label3.Text = resu.calcidade()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Label3.Text = ""
    End Sub
End Class