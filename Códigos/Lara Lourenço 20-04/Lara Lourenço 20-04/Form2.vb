Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If (a > b) Then
            Label3.Text = "O valor A é maior que B"
        ElseIf (a < b) Then
            Label3.Text = "O valor A é menor que B"
        Else
            Label3.Text = "Os valores A e B são iguais"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class