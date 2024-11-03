using DesafioPratico.Desafios;

namespace DesafioPratico;

public class Progrma()
{
    static void Main()
    {
        DesafioUm.Executar();
        QuebraLinha();
        DesafioDois.Executar();
        QuebraLinha();
        DesafioTres.Executar();
        QuebraLinha();
        DesafioQuatro.Executar();
        QuebraLinha();
        DesafioCinco.Executar();
        QuebraLinha();
        DesafioSeis.Executar();

        QuebraLinha();
        Console.WriteLine("FIM DO DESAFIO...");
    }

    private static void QuebraLinha()
    {
        Console.WriteLine("\n\n\tCARREGANDO PRÓXIMO DESAFIO\n");
        Thread.Sleep(2000);
        Console.WriteLine("\n\n");
    }
}