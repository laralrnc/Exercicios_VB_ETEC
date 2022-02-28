Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PictureBox1.Image = My.Resources.Calcultr
        PictureBox1.Visible = True

        If CheckBox1.Checked = False Then
            PictureBox1.Visible = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        PictureBox2.Image = My.Resources.CopyMach
        PictureBox2.Visible = True

        If CheckBox2.Checked = False Then
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class