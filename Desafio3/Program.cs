using System;

public class Desafio3
{
    static void Main()
    {
        Console.WriteLine("Quantos Carros deseja adicionar?");
        int quantidadeCarros = int.Parse(Console.ReadLine());

        string [] nomeCarros = new string[quantidadeCarros];

        for(int i =0; i < quantidadeCarros; i++)
        {
            Console.WriteLine($"Digite o nome do Carro {i + 1}:");
            AdicionarCarro(i, nomeCarros);
        }
        ExibirResumoCarros(quantidadeCarros, nomeCarros);

        Console.WriteLine("Deseja remover  um Carro ?(S/N)");
        string resposta = Console.ReadLine().ToUpper();

        if ( resposta == "S") 
        {
            Console.WriteLine("digite o jogo que quer remover:");
            string carroRemover = Console.ReadLine();
            bool carroEncontrado = RemoverCarro(carroRemover, ref quantidadeCarros, nomeCarros);

            if (carroEncontrado) 
            {
                Console.WriteLine($"\n0 Carro '{carroRemover}' foi removido com sucesso");
                ExibirResumoCarros(quantidadeCarros, nomeCarros);
            }

            else
            {
                Console.WriteLine($"\n0 Carro '{carroRemover}' não foi encontrado na lista");
               
            }
        }

    }
    static void AdicionarCarro(int indice, string[] nomes)
    {
    nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoCarros(int quantidadeCarros, string[] nomes)
    {
        Console.WriteLine($"\nfoi adicionado '{quantidadeCarros}' Carros: ");
        for(int i = 0; i < quantidadeCarros; i++)
        {
            Console.Write(nomes[i]);
            if(i < quantidadeCarros - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("  ao catalogo.");

    }

    static bool RemoverCarro(string carroRemover, ref int quantidadedeCarros, string[] nomes) 
    {
        for (int i = 0;i < quantidadedeCarros;i++) 
        {
            if (nomes[i] == carroRemover) 
            {
                for(int j = i; j < quantidadedeCarros - 1; j++)
                {
                    nomes[j] = nomes[j + 1];
                }
                nomes[quantidadedeCarros - 1] = null;

                quantidadedeCarros--;
                return true;
            }
        }
        return false;
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