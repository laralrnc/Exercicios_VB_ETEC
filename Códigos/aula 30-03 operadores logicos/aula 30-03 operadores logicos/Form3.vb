Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sexo As String
        sexo = TextBox1.Text.ToLower
        If (sexo = "feminino") Or (sexo = "masculino") Then
            MsgBox("sexo valido", MsgBoxStyle.Information, "verdadeiro")
        Else
            MsgBox("sexo invalido", vbCritical, "falso")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class