﻿Public Class Form8
    Public exer As New exer7
   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exer.mes = Val(TextBox1.Text)
        exer.calcmes()
        Label3.Text = exer.calcmes
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Label3.Text = ""
    End Sub
End Class