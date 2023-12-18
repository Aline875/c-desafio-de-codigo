using System;

class Desafio1 {
    static void Main() 
    {
        Console.WriteLine("digite o titulo:");
        string titulo = Console.ReadLine();

        Console.WriteLine("digite a Descrição");
        string descricao = Console.ReadLine();

        Console.WriteLine("digite a data de vencimento;");
        string dataVencimento = Console.ReadLine();

        if(descricao.Length > 50)
        {
            Console.WriteLine("O números de caracteres excedidos na descrição!");
        }
        else{
            Console.WriteLine("Tarefa Adicionada:");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Descrição: {descricao}");
            Console.WriteLine($"Data de Vencimento: {dataVencimento}");
        }
    }
}