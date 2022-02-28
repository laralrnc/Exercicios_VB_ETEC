Public Class cadAluno
    Public nome As String
    Public nota(4) As Single 'atributos'
    Function calcmedia() As Single 'criando a função + atributos'
        Dim soma, media As Single
        soma = nota(1) + nota(2) + nota(3) + nota(4)
        media = soma / 4
        calcmedia = media 'função recebe o resultado da variavel'
    End Function
End Class
