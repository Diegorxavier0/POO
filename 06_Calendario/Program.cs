using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
           
            for (int mes = 1; mes <= 12; mes++)
            {
                calendario = new Calendario(ano, mes);
                calendario.ImprimeCalendario();
                Console.WriteLine("\n\n");

            }
            Console.ReadKey();
        }

    
    }
}