using System;

namespace _17_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
            for (int mes = 1; mes <= 12; mes++)
            {
                calendario = new Calendario(ano, (Mes)mes);
                calendario.ImprimirCalendario();

                Console.WriteLine("\n\n");

            }
            //Espera o usuário teclar qualquer tecla
            Console.ReadKey();
        }
    }
}