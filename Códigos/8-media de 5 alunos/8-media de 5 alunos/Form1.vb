Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, med1, med2, med3, med4, med5 As Double

        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        med1 = (n1 + n2 + n3) / 3
        Label30.Text = med1

        n4 = TextBox10.Text
        n5 = TextBox11.Text
        n6 = TextBox12.Text
        med2 = (n4 + n5 + n6) / 3
        Label33.Text = med2

        n7 = TextBox7.Text
        n8 = TextBox8.Text
        n9 = TextBox9.Text
        med3 = (n7 + n8 + n9) / 3
        Label35.Text = med3

        n10 = TextBox13.Text
        n11 = TextBox14.Text
        n12 = TextBox15.Text
        med4 = (n10 + n11 + n12) / 3
        Label25.Text = med4

        n13 = TextBox4.Text
        n14 = TextBox5.Text
        n15 = TextBox6.Text
        med5 = (n13 + n14 + n15) / 3
        Label34.Text = med5


    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        Label30.Text = " "
        Label33.Text = " "
        Label35.Text = " "
        Label34.Text = " "
        Label25.Text = " "


    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class
