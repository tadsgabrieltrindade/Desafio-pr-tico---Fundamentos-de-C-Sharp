//5.Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
//  -A placa deve ter 7 caracteres alfanuméricos;
//  -Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
//  -Os quatro últimos caracteres são números;

//Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
using System.Text.RegularExpressions;

namespace DesafioPratico.Desafios;

public static class DesafioCinco
{
    public static void Executar()
    {
        Console.WriteLine("Executando desafio cinco...\n");
        Thread.Sleep(1000);

        //Ler o do prompt
        Console.WriteLine("Digite a placa do veículo ");
        var placa = Console.ReadLine();

        bool tresPrimeirasLetras = Regex.IsMatch(placa, @"^[a-zA-Z]{3}");
        bool quatroUltimosNumeros = Regex.IsMatch(placa, @"\d{4}$");

        if (placa.Length == 7 && tresPrimeirasLetras && quatroUltimosNumeros)
            Console.WriteLine("\nVerdadeiro");
        else
            Console.WriteLine("\nFalso");
    }
}
