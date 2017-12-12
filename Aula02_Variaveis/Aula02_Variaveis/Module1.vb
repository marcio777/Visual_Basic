Module Module1

    Sub Main()
        Dim num1, num2 As String   'Variaveis para armazenar dados do usuario'
        Dim numero1, numero2, soma, subr, mult, div As Double 'Variaveis utilizadas no cálculo'


        Console.WriteLine("Digite um numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite outro numero")
        num2 = Console.ReadLine()

        numero1 = CDbl(num1)     ' CDbl Converte uma expressão para Double'
        numero2 = CDbl(num2)
        soma = numero1 + numero2
        subr = numero1 - numero2
        mult = numero1 * numero2
        div = numero1 / numero2

        'Exibir os resultados'
        Console.WriteLine("A soma e: ")
        Console.WriteLine(soma)
        Console.WriteLine("A subratação e: ")
        Console.WriteLine(subr)
        Console.WriteLine("A Multiplicação e: ")
        Console.WriteLine(mult)
        Console.WriteLine("A Divisão e: ")
        Console.WriteLine(div)


        Console.ReadLine()

    End Sub

End Module
