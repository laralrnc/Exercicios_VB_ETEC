﻿Public Class Form3
    Dim quadrado As New quadrado

    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        quadrado.num = Val(TextBox1.Text)
        quadrado.calcquadrado()

        Label3.Text = quadrado.calcquadrado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class