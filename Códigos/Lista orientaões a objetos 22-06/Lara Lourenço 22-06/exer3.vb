Public Class exer3
    Public idade As Integer
    Function calcidade() As String
        Dim resu As String
        If (idade > 18) Then
            resu = "Você é maior de idade"
            calcidade = resu
        Else
            resu = "Você é menor de idade"
            calcidade = resu
        End If
    End Function
End Class
