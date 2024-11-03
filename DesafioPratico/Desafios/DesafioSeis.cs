//6. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
//  -Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
//  - Apenas a data no formato "01/03/2024".
//  - Apenas a hora no formato de 24 horas.
//  - A data com o mês por extenso.
using System.Globalization;
using System.Text.RegularExpressions;

namespace DesafioPratico.Desafios;

public static class DesafioSeis
{
    public static void Executar()
    {
        Console.WriteLine("Executando desafio seis...\n");
        Thread.Sleep(1000);

        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("\nEscolha o formato de exibição da data:\n");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato 'dd/MM/yyyy'");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - Data com o mês por extenso");

        Console.Write("\nDigite a opção desejada (1, 2, 3 ou 4): ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("\nFormato completo: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case "2":
                Console.WriteLine("\nData: " + dataAtual.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine("\nHora (24h): " + dataAtual.ToString("HH:mm"));
                break;
            case "4":
                Console.WriteLine("\nData com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("\nOpção inválida.");
                break;
        }

    }
}
