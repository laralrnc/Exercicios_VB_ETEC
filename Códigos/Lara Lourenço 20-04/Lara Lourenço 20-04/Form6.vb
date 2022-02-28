Public Class Form6

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p, c As Double
        p = Val(TextBox1.Text)
        c = Val(TextBox2.Text)
        If c = 1 Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Sul do Brasil"
        ElseIf c = 2 Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Norte do Brasil"
        ElseIf c = 3 Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Leste do Brasil"
        ElseIf c = 4 Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Oeste do Brasil"
        ElseIf (c = 5) Or (c = 6) Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Nordeste do Brasil"
        ElseIf (c = 7) Or (c = 8) Or (c = 9) Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Sudeste do Brasil"
        ElseIf (c >= 25) And (c <= 30) Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Nordeste do Brasil"
        ElseIf (c >= 10) And (c <= 20) Then
            Label6.Text = "O preço do produto é " & p & " reais e é um produto do Centro-Oeste do Brasil"
        Else
            Label6.Text = "O preço do produto é " & p & " reais e é um produto importado"


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label6.Text = ""

    End Sub
End Class