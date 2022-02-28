Public Class Form5

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, sex As String
        Dim alt As Double
        n = TextBox1.Text
        sex = (TextBox3.Text.ToUpper)
        alt = Val(TextBox2.Text)

        If (sex = "MASCULINO") Then
            Label4.Text = n & ", o seu peso ideal é " & (72.7 * alt) - 58 & ("kg")
        ElseIf (sex = "FEMININO") Then
            Label4.Text = n & ", o seu peso ideal é " & (62.1 * alt) - 44.7 & ("kg")
        Else
            Label4.Text = "Sexo Inválido"
        End If
    End Sub
End Class