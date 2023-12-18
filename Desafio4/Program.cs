using System;

public class Desafio3 
{
    static void Main()
    {
        string nome = Console.ReadLine();
        double  quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasEletronicos = int.Parse(Console.ReadLine()); 
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        double pegadaDeCarbono = CaulularPegadaDeCarbono( quilometrosPorDia, horasEletronicos, refeicoesComCarne);
        Console.WriteLine($"{nome}, sua pegada de carbone é {pegadaDeCarbono:F1} toneladas de CO2 por ano");

        Console.ReadLine();
    }

    static double CaulularPegadaDeCarbono(double quilometrosPorDia, int horasEletronicos, int refeicoesComCarne )
    {
        double pegadaTransporte = quilometrosPorDia *365 * 0.2;
        double pegadaEletronicos = horasEletronicos *0.1;
        double pegadaCarne = refeicoesComCarne *0.5;

        double pegadaTotal = pegadaTransporte+pegadaEletronicos+pegadaCarne;
        return pegadaTotal;
    }

}
