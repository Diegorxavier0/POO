using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TratamentoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            while (true)
            {
                Console.WriteLine("Digite um número inteiro: ");
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Numero invalido, informe apenas valores inteiros!\nPressione qualquer tela para continuar");
                    Console.ReadKey();// Pausa o programa até que uma tecla seja pressionada
                }
                finally
                {
                   
                    Console.Clear();// Limpa a tela
                    // Sempre será executado
                }


            }


            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

        }
    }
}