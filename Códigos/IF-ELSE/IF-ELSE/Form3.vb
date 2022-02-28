Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4, n5 As String
        Dim age1, age2, age3, age4, age5 As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        n5 = TextBox5.Text
        age1 = Val(TextBox6.Text)
        age2 = Val(TextBox7.Text)
        age3 = Val(TextBox8.Text)
        age4 = Val(TextBox9.Text)
        age5 = Val(TextBox10.Text)

        If (age1 > 20) Then
            Label11.Text = "O morador " & n1 & " possui mais de vinte anos"
        End If
        If (age2 > 20) Then
            Label12.Text = "O morador " & n2 & " possui mais de vinte anos"
        End If
        If (age3 > 20) Then
            Label13.Text = "O morador " & n3 & " possui mais de vinte anos"
        End If
        If (age4 > 20) Then
            Label14.Text = "O morador " & n4 & " possui mais de vinte anos"
        End If
        If (age5 > 20) Then
            Label15.Text = "O morador " & n5 & " possui mais de vinte anos"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
End Class