Public Class exer4
    Public num As Integer
    Function calcparimpar() As String
        Dim resu As String
        If num Mod 2 = 0 Then
            resu = "O número digitado é par "
            calcparimpar = resu
        Else
            resu = "O número digitado é impar"
            calcparimpar = resu
        End If
    End Function
End Class
