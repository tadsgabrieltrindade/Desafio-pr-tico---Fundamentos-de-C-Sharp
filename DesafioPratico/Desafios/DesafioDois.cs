//Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.


namespace DesafioPratico.Desafios;

public static class DesafioDois
{
    public static void Executar()
    {
        Console.WriteLine("Executando desafio dois...\n");
        Thread.Sleep(1000);

        //Ler o do prompt
        Console.WriteLine("Qual é o seu primeiro nome?");
        var nome = Console.ReadLine();

        Console.WriteLine("E o seu sobrenome?");
        var sobrenome = Console.ReadLine();


        Console.WriteLine($"\nOlá, {nome} {sobrenome}! Seja bem-vindo!");
    }
}
