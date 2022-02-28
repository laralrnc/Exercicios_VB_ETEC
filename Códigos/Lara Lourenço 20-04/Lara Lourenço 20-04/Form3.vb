Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4, n5 As String
        Dim id1, id2, id3, id4, id5 As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        n5 = TextBox5.Text
        id1 = Val(TextBox6.Text)
        id2 = Val(TextBox7.Text)
        id3 = Val(TextBox8.Text)
        id4 = Val(TextBox9.Text)
        id5 = Val(TextBox10.Text)
        If (id1 > 20) Then
            Label3.Text = " O morador(a) " & n1 & " possui mais de 20 anos de idade"
        End If
        If (id2 > 20) Then
            Label4.Text = " O morador(a) " & n2 & " possui mais de 20 anos de idade"

        End If
        If (id3 > 20) Then
            Label5.Text = " O morador(a) " & n3 & " possui mais de 20 anos de idade"

        End If
        If (id4 > 20) Then
            Label6.Text = " O morador(a) " & n4 & " possui mais de 20 anos de idade"

        End If
        If (id5 > 20) Then
            Label7.Text = " O morador(a) " & n5 & " possui mais de 20 anos de idade"
        End If
        


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class