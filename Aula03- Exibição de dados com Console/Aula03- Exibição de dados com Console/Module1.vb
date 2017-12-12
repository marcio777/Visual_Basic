Module Module1

    Sub Main()

        Dim numero As Integer
        Dim nome As String

        Console.WriteLine("Digite um numero:")
        numero = Console.ReadLine()

        Console.WriteLine("Digite seu nome :")
        nome = Console.ReadLine()

        '  Console.WriteLine("O numero digitado foi : " & numero & " Pelo usuario " & nome) '& e usado para concatenar no visual Basic'

        Console.WriteLine("O numero digitado foi: {0} pelo usuario {1}", numero, nome)  ' Aqui eu posso ordenar as variaveis por indice por ordem nas chaves.


        Console.ReadLine()




    End Sub

End Module
