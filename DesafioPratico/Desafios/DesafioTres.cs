//1.Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
//  -A soma entre esses dois números;
//  -A subtração entre os dois números;
//  -A multiplicação entre os dois números;
//  -A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
//  -A média entre os dois números.

namespace DesafioPratico.Desafios;

public static class DesafioTres
{
    public static void Executar()
    {
        Console.WriteLine("Executando desafio três...\n");
        Thread.Sleep(1000);

        //Ler o do prompt
        Console.WriteLine("Qual é o seu primeiro número?");
        string primeiro = Console.ReadLine();

        Console.WriteLine("E o segundo?");
        string segundo = Console.ReadLine();

        double num1 = double.Parse(primeiro);
        double num2 = double.Parse(segundo);


        Console.WriteLine("\nResultados: \n");
        var soma = num1 + num2;
        Console.WriteLine($"Soma entre {primeiro} e o {segundo} é {soma}\n");
        var sub = num1 - num2;
        Console.WriteLine($"Subtração entre {primeiro} e o {segundo} é {sub}\n");
        var mult = num1 * num2;
        Console.WriteLine($"Multiplicação entre {primeiro} e o {segundo} é {mult}\n ");
        var div = num1 / num2;
        Console.WriteLine($"divisão entre {primeiro} e o {segundo} é {div}\n");
        var media = (num1 + num2) / 2;
        Console.WriteLine($"média entre {primeiro} e o {segundo} é {media}\n\n");
    }
}
