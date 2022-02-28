Public Class Form9

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salb, sall, com, inss, sal As Double
        Dim nome As String
        nome = TextBox1.Text
        sal = TextBox2.Text
        com = TextBox3.Text
        If (sal <= 1000) Then
            inss = sal * 0.08
            salb = sal + com
            sall = salb + inss
            Label6.Text = "O funcionário " & nome & " possui um desconto de INSS = " & inss & " e o salário bruto de " & salb & " e o salário liquido é igual a " & sall & ""
        ElseIf (sal > 1000) And (salb <= 1500) Then
            inss = sal * 0.09
            salb = sal + com
            sall = salb + inss
            Label6.Text = "O funcionário " & nome & " possui um desconto de INSS = " & inss & " e o salário bruto de " & salb & " e o salário liquido é igual a " & sall & ""
        Else
            salb = sal + com
            inss = salb * 0.11
            sall = salb + inss
            Label6.Text = "O funcionário " & nome & " possui um desconto de INSS = " & inss & " e o salário bruto de " & salb & " e o salário liquido é igual a " & sall & ""

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label6.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class