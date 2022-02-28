Public Class Form5

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = ""
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        id = Val(TextBox1.Text)
        Select Case id
            Case Is < 13
                Label2.Text = "Aproveite sua infancia!"
            Case Is > 13 < 20
                Label2.Text = "Aproveite sua juventude!"
            Case 21
                Label2.Text = "Você chegou a maioridade!"
            Case Else
                Label2.Text = "Você é um adulto!"
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub
End Class