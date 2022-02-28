Public Class Form6

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price, from As Double
        price = Val(TextBox1.Text)
        from = Val(TextBox2.Text)

        If (from = 1) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Sul"
        ElseIf (from = 2) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Norte"
        ElseIf (from = 3) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Leste"
        ElseIf (from = 4) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Oeste"
        ElseIf (from = 5) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Nordeste"
        ElseIf (from = 6) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Nordeste"
        ElseIf (from > 6) And (from < 10) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Sudeste"
        ElseIf (from > 9) And (from < 21) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Centro-Oeste"
        ElseIf (from > 24) And (from < 31) Then
            Label3.Text = "O produto custa R$" & price & " e vem do Nordeste"
        Else
            Label3.Text = "Códgio Inválido"
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class