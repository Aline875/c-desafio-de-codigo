using System;
public class Desafio2
{
    static void Main()
    {
        int limiteInferior = int.Parse(Console.ReadLine());
        int limiteSuperior = int.Parse(Console.ReadLine());

        int somaPares = 0;

        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            if(i % 2 == 0)
            {
                somaPares += i;
            }
        }

        Console.WriteLine($"A soma dos números pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");

    }
}