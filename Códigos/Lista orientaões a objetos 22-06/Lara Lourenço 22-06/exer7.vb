Public Class exer7
    Public mes As Double
    Function calcmes() As String
        Dim resu As String
        If mes = 1 Or mes = 2 Or mes = 3 Then
            resu = "O mês " & mes & " faz parte do primeiro trimestre do ano "
            calcmes = resu
        ElseIf mes = 4 Or mes = 5 Or mes = 6 Then
            resu = "O mês " & mes & " faz parte do segundo trimestre do ano "
            calcmes = resu
        ElseIf mes = 7 Or mes = 8 Or mes = 9 Then
            resu = "O mês  " & mes & " faz parte do terceiro trimestre do ano "
            calcmes = resu
        ElseIf mes = 10 Or mes = 11 Or mes = 12 Then
            resu = "O mês " & mes & " faz parte do quarto trimestre do ano "
            calcmes = resu
        ElseIf mes > 12 Then
            resu = "ERRO"
            calcmes = resu
        End If

    End Function
End Class

