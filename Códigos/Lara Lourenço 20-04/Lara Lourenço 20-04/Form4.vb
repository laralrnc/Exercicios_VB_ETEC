Public Class Form4

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Double
        num = TextBox1.Text
        If (num Mod 2 = 0) Then
            MsgBox("O número é par", MsgBoxStyle.Information, "Par")
        Else
            MsgBox("O número é impar", MsgBoxStyle.Information, "Impar")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class