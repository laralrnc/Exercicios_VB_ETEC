Public Class Form1
    Dim aluno As New cadAluno 'criação do objeto'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aluno.nome = TextBox1.Text 'objeto.atributo recebe o valor da textbox

        aluno.nota(1) = Val(TextBox2.Text)
        aluno.nota(2) = Val(TextBox2.Text)
        aluno.nota(3) = Val(TextBox2.Text)
        aluno.nota(4) = Val(TextBox2.Text)

        'objeto.metodo
        aluno.calcmedia()

        'mostra na label o resultado da media (label recebe nome do objeto.nome do metodo
        Label6.Text = Format(aluno.calcmedia(), "#0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label6.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
