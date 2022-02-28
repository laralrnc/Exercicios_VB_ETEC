Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2 As Double
        Dim op As String
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        op = TextBox3.Text
        If (op = "*") Then
            Label2.Text = n1 * n2
        ElseIf (op = "-") Then
            Label2.Text = n1 - n2
        ElseIf (op = "+") Then
            Label2.Text = n1 + n2
        Else
            Label2.Text = n1 / n2
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class