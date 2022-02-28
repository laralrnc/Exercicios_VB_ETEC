Public Class exer6
    Public amigos As Integer
    Public balas As Integer
    Function calcab() As String
        Dim resu, resto As Double
        If balas Mod amigos = 0 Then
            resu = balas / amigos
            calcab = "Cada amigo receberá " & resu & " bala(s)"
        Else
            resu = balas / amigos
            resto = amigos Mod balas
            calcab = "Cada amigo receberá " & resu & " bala(s) mas sobrará " & resto & ""
        End If

    End Function

End Class
