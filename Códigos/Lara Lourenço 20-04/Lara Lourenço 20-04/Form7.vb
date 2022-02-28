Public Class Form7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim placa As Double
        placa = Val(TextBox1.Text)
        If (placa = 1) Or (placa = 2) Then
            Label4.Text = "O final da sua placa é  " & placa & " e você não pode circular nas segundas-feiras das 7 às 10 horas e das 17 às 20 horas no centro expandido de São Paulo. "
        ElseIf (placa = 3) Or (placa = 4) Then
            Label4.Text = "O final da sua placa é  " & placa & " e você não pode circular nas terças-feiras das 7 às 10 horas e das 17 às 20 horas no centro expandido de São Paulo. "
        ElseIf (placa = 5) Or (placa = 6) Then
            Label4.Text = "O final da sua placa é  " & placa & " e você não pode circular nas quartas-feiras  das 7 às 10 horas e das 17 às 20 horas no centro expandido de São Paulo. "
        ElseIf (placa = 7) Or (placa = 8) Then
            Label4.Text = "O final da sua placa é  " & placa & " e você não pode circular nas quintas-feiras das 7 às 10 horas e das 17 às 20 horas no centro expandido de São Paulo. "
        Else
            Label4.Text = "O final da sua placa é  " & placa & " e você não pode circular nas sextas-feiras das 7 às 10 horas e das 17 às 20 horas  no centro expandido de São Paulo. "
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label4.Text = ""

    End Sub
End Class