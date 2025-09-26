using System;
using System.Collections.Generic;
using System.Linq; // precisa para usar Reverse()

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            Console.WriteLine("Elementos na pilha (ordem de entrada):");
            foreach (var item in pilha.Reverse())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nImpressão dos pilhaNomes\n");
            Console.WriteLine($"Ultimo inserido: {pilha.Pop()}");
        }
    }
}
