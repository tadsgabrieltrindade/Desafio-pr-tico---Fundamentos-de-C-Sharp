//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem. 
namespace DesafioPratico.Desafios;

public static class DesafioQuatro
{
    public static void Executar()
    {
        Console.WriteLine("Executando desafio quarto...\n");
        Thread.Sleep(1000);

        //Ler o do prompt
        Console.WriteLine("Digite um texto ");
        var texto = Console.ReadLine();
        int quantidade = 0;
        var lista = texto.Split(' ');

        foreach (var item in lista)
        {
            quantidade = quantidade + item.Trim().Length;
        }
        
        Console.WriteLine($"\nO texto digitado contém {quantidade} caracteres.");
    }
}
