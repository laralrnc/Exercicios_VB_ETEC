Public Class exer5
    Public val As Double
    Public porcen As Double
    Function calporcen() As Double
        Dim resu As Double
        resu = (val * porcen) / 100
        calporcen = val - resu
    End Function

End Class
