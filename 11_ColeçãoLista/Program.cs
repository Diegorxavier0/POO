using System;
using System.Collections.Generic;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            Console.WriteLine("Digite 5 nomes (mínimo 3 caracteres cada):");

            while (nomes.Count < 5)
            {
                Console.Write($"Nome {nomes.Count + 1}: ");
                string nome = Console.ReadLine();

                if (nome.Length >= 3) //validação
                {
                    nomes.Add(nome);
                }
                else
                {
                    Console.WriteLine("❌ Nome inválido, precisa ter pelo menos 3 caracteres");
                }
            }

            Console.WriteLine("\nImpressão dos nomes\n");
            foreach (string nome in nomes)
            {
                Console.WriteLine($" - {nome}");
            }
        }
    }
}
