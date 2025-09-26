using System;
using System.Collections.Generic;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            Console.WriteLine("Digite os nomes da fila de atendimento (mínimo 3 caracteres).");
            Console.WriteLine("Serão cadastrados pelo menos 5 nomes.\n");

            while (fila.Count < 5) // vamos cadastrar pelo menos 6
            {
                Console.Write($"Nome {fila.Count + 1}: ");
                string nome = Console.ReadLine();

                if (nome.Length >= 3) // validação
                {
                    fila.Enqueue(nome);
                }
                else
                {
                    Console.WriteLine(" Nome inválido, precisa ter pelo menos 3 caracteres.");
                }
            }

            Console.WriteLine("\nAtendimentos realizados:");
            Console.WriteLine($"1º) {fila.Dequeue()}");
            Console.WriteLine($"2º) {fila.Dequeue()}");
            Console.WriteLine($"3º) {fila.Dequeue()}");

            Console.WriteLine("\nAinda aguardam na fila:");
            foreach (string nome in fila)
            {
                Console.WriteLine($" - {nome}");
            }
        }
    }
}
