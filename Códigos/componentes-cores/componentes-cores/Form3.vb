Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Panel1.BackColor = Color.LightBlue
        If CheckBox1.Checked = False Then
            Panel1.BackColor = Color.White

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Panel2.BackColor = Color.Red
        If CheckBox2.Checked = False Then
            Panel2.BackColor = Color.White

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Panel3.BackColor = Color.Yellow
        If CheckBox3.Checked = False Then
            Panel3.BackColor = Color.White

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Panel4.BackColor = Color.Black
        If CheckBox4.Checked = False Then
            Panel4.BackColor = Color.White

        End If
    End Sub
End Class