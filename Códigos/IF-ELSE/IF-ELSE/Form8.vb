Public Class Form8

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        End
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n3 As Double
        Dim op As String
        n1 = Val(TextBox1.Text)
        op = TextBox2.Text.ToUpper
        n3 = Val(TextBox3.Text)

        If (op = "SOMA") Then
            Label3.Text = n1 + n3
        ElseIf (op = "SUBTRAÇÃO") Then
            Label3.Text = n1 - n3
        ElseIf (op = "DIVISÃO") Then
            Label3.Text = n1 / n3
        ElseIf (op = "MULTIPLICAÇÃO") Then
            Label3.Text = n1 * n3
        Else
            Label3.Text = "Operação Inválida"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class