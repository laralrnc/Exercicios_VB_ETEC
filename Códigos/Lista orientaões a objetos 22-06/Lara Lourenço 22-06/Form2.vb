Public Class Form2
    Dim numero As New dobro
    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numero.num = Val(TextBox1.Text)
        numero.calcdobro()

        Label3.Text = numero.calcdobro()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class