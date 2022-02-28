Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sb, c, inss, sl, sbf As Double
        Dim nome As String
        nome = TextBox1.Text
        sb = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        sbf = sb + c

        If (sbf <= 1000) Then
            Label4.Text = nome & ", seu salário bruto é de R$" & sbf & ", o desconto do INSS é de R$" & (sbf * 0.08) & " e seu salário líquido é de R$" & sbf - (sbf * 0.08) & "."
        ElseIf (sbf > 1000) And (sb <= 1500) Then
            Label4.Text = nome & ", seu salário bruto é de R$" & sbf & ", o desconto do INSS é de R$" & (sbf * 0.09) & " e seu salário líquido é de R$" & sbf - (sbf * 0.09) & "."
        Else
            Label4.Text = nome & ", seu salário bruto é de R$" & sbf & ", o desconto do INSS é de R$" & (sbf * 0.11) & " e seu salário líquido é de R$" & sbf - (sbf * 0.11) & "."
        End If
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class