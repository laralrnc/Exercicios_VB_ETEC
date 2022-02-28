Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sexo, nome As String
        Dim alt As Double
        nome = TextBox1.Text
        alt = TextBox2.Text
        sexo = TextBox3.Text.ToLower
        If sexo = "feminino" Then
            Label3.Text = "Seu peso ideal é " & (62.1 * alt) - 44.7 & ""
        Else
            Label3.Text = "Seu peso ideal é " & (72.7 * alt) - 58 & ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class