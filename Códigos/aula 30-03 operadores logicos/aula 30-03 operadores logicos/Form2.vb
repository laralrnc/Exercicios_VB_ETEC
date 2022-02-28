Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Single
        x = Val(TextBox2.Text)
        If (x >= 20) And (x <= 90) Then
            MsgBox("O valor" & x & "está entre 20 e 90", MsgBoxStyle.Information, "verdadeiro")
        Else
            MsgBox("o valor não está entre 20 e 90", vbCritical, "falso")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class