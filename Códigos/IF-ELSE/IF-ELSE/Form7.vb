Public Class Form7

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text

        If (n = 1) Then
            Label2.Text = "Você não pode circular no Centro expandido na Segunda-feira, das 0h Às 12h"
        ElseIf (n = 2) Then
            Label2.Text = "Você não pode circular no Centro expandido na Terça-feira, das 12h Às 0h"
        ElseIf (n = 3) Then
            Label2.Text = "Você não pode circular no Centro expandido na Quarta-feira, das 0h Às 12h"
        ElseIf (n = 4) Then
            Label2.Text = "Você não pode circular no Centro expandido na Quinta-Feira, das 12h Às 0h"
        ElseIf (n = 5) Then
            Label2.Text = "Você não pode circular no Centro expandido na Sexta-feira, das 0h Às 12h"
        ElseIf (n = 6) Then
            Label2.Text = "Você não pode circular no Centro expandido na Segunda-feira, das 12h Às 0h"
        ElseIf (n = 7) Then
            Label2.Text = "Você não pode circular no Centro expandido na Terça-feira, das 0h Às 12h"
        ElseIf (n = 8) Then
            Label2.Text = "Você não pode circular no Centro expandido na Quarta-feira, das 12h Às 0h"
        ElseIf (n = 9) Then
            Label2.Text = "Você não pode circular no Centro expandido na Quinta-Feira, das 0h Às 12h"
        ElseIf (n = 0) Then
            Label2.Text = "Você não pode circular no Centro expandido na Sexta-feira, das 12h Às 0h"
        Else
            Label2.Text = "Código Inválido"
        End If
    End Sub
End Class