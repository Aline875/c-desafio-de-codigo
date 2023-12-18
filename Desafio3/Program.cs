using System;

public class Desafio3
{
    static void Main()
    {
        Console.WriteLine("Quantos jogos deseja adicionar?");
        int quantidadeJogos = int.Parse(Console.ReadLine());

        string [] nomeJogos = new string[quantidadeJogos];

        for(int i =0; i < quantidadeJogos; i++)
        {
            Console.WriteLine($"Digite o nome do jogo {i + 1}:");
            Adicionarjogo(i, nomeJogos);
        }
        ExibirResumoJogos(quantidadeJogos, nomeJogos);
    }
    static void Adicionarjogo(int indice, string[] nomes)
    {
    nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.WriteLine($"foi adicionado '{quantidadeJogos}' jogos: ");
        for(int i = 0; i < quantidadeJogos; i++)
        {
            Console.Write(nomes[i]);
            if(i < quantidadeJogos - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("  ao catalogo.");
    }
}

// using System;

// public class Desafio3
// {
//     static void Main()
//     {
//         int quantidadeJogos;

//         while (int.TryParse(Console.ReadLine(),out quantidadeJogos));
//         {
//             string [] nomeJogos = new string[quantidadeJogos];

//             for (int i = 0; i < quantidadeJogos; i++)
//             {
//                 nomeJogos[i] = Console.ReadLine();
//             }
            
//             ExibirResumoAdicaoJogos(quantidadeJogos, nomeJogos);

//          }
//          static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
//          {
//             Console.Write($"foi adicionada '{quantidadeJogos}' jogos:");
//             for(int i = 0; i < quantidadeJogos; i++)
//             {
//                 Console.Write(nomes[i]);
//                 if(i < quantidadeJogos - 1)
//                 {
//                     Console.Write(" ,");
//                 }
                
//             }
//             Console.WriteLine(" ao catalogo.");

//         }
//     }
// }