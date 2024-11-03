//Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

namespace DesafioPratico.Desafios;

public static class DesafioUm
{
    public static void Executar()
    {
        Console.WriteLine("Executando desafio um...\n");
        Thread.Sleep(1000);

        //Ler o do prompt
        Console.WriteLine("Olá, qual é o seu nome? ");
        var nome = Console.ReadLine();

        Console.WriteLine($"\nOlá, {nome}! Seja bem-vindo!");
    }
}
