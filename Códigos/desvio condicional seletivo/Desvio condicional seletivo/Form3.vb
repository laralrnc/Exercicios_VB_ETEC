Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idioma As String
        idioma = TextBox1.Text.ToUpper
        Select Case idioma
            Case "INGLÊS"
                Label4.Text = "Hello world!"
            Case "ALEMÃO"
                Label4.Text = "Hallo Programmierer!"
            Case "ESPANHOL"
                Label4.Text = "Hola programador!"
            Case "ITALIANO"
                Label4.Text = "Ciao programmatore!"
            Case Else
                Label4.Text = "Idioma invalido"
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Text = ""
        TextBox1.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class