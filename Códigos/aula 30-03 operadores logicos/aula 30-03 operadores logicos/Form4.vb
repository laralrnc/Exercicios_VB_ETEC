Public Class Form4

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, S2, n1, n2 As String
        s1 = TextBox1.Text.ToLower
        S2 = TextBox2.Text.ToLower
        n1 = TextBox3.Text.ToLower
        n2 = TextBox4.Text.ToLower
        If (s1 = "masculino") Xor (S2 = "masculino") Then
            MsgBox("Os alunos " & n1 & " e " & n2 & " podem dançar", MsgBoxStyle.Information, "verdadeiro")
        Else
            MsgBox("Os alunos" & n1 & "e" & n2 & " não podem dançar", vbCritical, "falso")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class