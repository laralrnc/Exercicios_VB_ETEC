Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        id = Val(TextBox1.Text)
        Select Case id
            Case 16
                Label2.Text = "Você já pode votar!"
            Case 18
                Label2.Text = "Você já pode dirigir!"
            Case 21
                Label2.Text = "Você chegou a maioridade!"
            Case 65
                Label2.Text = "Você já pode se aposentar e descansar agora!"
            Case Else
                Label2.Text = "Aproveite sua vida!"
        End Select


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = ""
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub
End Class