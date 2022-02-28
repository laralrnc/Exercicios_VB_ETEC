Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Disquete")
        ComboBox1.Items.Add("zipdisc")
        ComboBox1.Items.Add("pendrive")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
         Select ComboBox1.SelectedIndex
            Case 0
                PictureBox1.Image = My.Resources.disquete
            Case 1
                PictureBox1.Image = My.Resources.zipdisc
            Case 2
                PictureBox1.Image = My.Resources.pendrive
        End Select
    End Sub
End Class