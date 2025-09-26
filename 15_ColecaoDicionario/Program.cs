using System;
using System.Collections.Generic;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dicAlunos = new Dictionary<int, string>();

            Console.Write("\nCadastre três alunos: \n ");
            //int qtd = int.Parse(Console.ReadLine());

           for (int i = 0; i < 3; i++)//se quiser que deixe pro usuario digitar a quantidade, ao inves de 3, altere para qtd,
                                      //e descomente a linha 12
            {
                Console.Write("\nDigite o RA: ");
                int ra = int.Parse(Console.ReadLine());

                string nome = "";
                while (nome.Length < 3)
                {
                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();

                    if (nome.Length < 3)
                    {
                        Console.WriteLine("Nome precisa ter pelo menos 3 letras!");
                    }
                }

                dicAlunos.Add(ra, nome);
            }

            Console.WriteLine("\nAlunos cadastrados:");
            foreach (var aluno in dicAlunos)
            {
                Console.WriteLine("RA: " + aluno.Key + " - Nome: " + aluno.Value);
            }

            Console.ReadKey();
        }
    }
}
