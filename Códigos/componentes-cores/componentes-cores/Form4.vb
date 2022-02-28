Public Class Form4

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            Me.BackColor = Color.LightBlue

        End If
        If ListBox1.SelectedIndex = 1 Then
            Me.BackColor = Color.LightGreen

        End If
        If ListBox1.SelectedIndex = 2 Then
            Me.BackColor = Color.Red

        End If
        If ListBox1.SelectedIndex = 3 Then
            Me.BackColor = Color.Yellow
        End If
    End Sub
End Class