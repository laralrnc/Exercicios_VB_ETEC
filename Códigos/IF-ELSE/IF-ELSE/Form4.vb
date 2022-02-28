Public Class Form4

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = Val(TextBox1.Text)

        If (n1 Mod 2 = 0) Then
            Label2.Text = "Esse número é par"
        Else
            Label2.Text = "Esse número é impar"
        End If

    End Sub
End Class