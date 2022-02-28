Public Class Form5

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Me.BackColor = Color.LightBlue
            Case 1
                Me.BackColor = Color.LightGreen
            Case 2
                Me.BackColor = Color.Red
            Case 3
                Me.BackColor = Color.Yellow

        End Select
    End Sub
End Class