Public Class Form2

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mes As Integer
        mes = Val(TextBox1.Text)
        Select Case mes
            Case 1
                Label2.Text = "janeiro"
            Case 2
                Label2.Text = "fevereiro"
            Case 3
                Label2.Text = "março"
            Case 4
                Label2.Text = "abril"
            Case 5
                Label2.Text = "maio"
            Case 6
                Label2.Text = "junho"
            Case 7
                Label2.Text = "julho"
            Case 8
                Label2.Text = "agosto"
            Case 9
                Label2.Text = "setembro"
            Case 10
                Label2.Text = "outubro"
            Case 11
                Label2.Text = "novembro"
            Case 12
                Label2.Text = "dezembro"
            Case Else
                Label2.Text = "mês invalido"
        End Select
    End Sub
End Class