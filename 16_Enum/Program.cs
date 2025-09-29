using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sem utilização de enum");
           //List<int> DiaSemanaSemEnum= new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            List<int> DiaSemanaSemEnum= new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("digite um numero");
            foreach (var item in DiaSemanaSemEnum)
            {
                if( item == 1)
                {
                    Console.WriteLine("Hoje é Domingo");
                }
                else if (item == 2)
                {
                    Console.WriteLine("Hoje é Segunda");
                }
                else if (item == 3)
                {
                    Console.WriteLine("Hoje é Terca");
                }
                else if (item == 4)
                {
                    Console.WriteLine("Hoje é Quarta");
                }
                else if (item == 5)
                {
                    Console.WriteLine("Hoje é Quinta");
                }
                else if (item == 6)
                {
                    Console.WriteLine("Hoje é Sexta");
                }
                else if (item == 7)
                {
                    Console.WriteLine("Hoje é Sabado");
                }
            }

            Console.WriteLine("\n\ncom enum");
            List<DiaDaSemana> DiaSemanaComEnum = new List<DiaDaSemana>()
            {
                DiaDaSemana.Domingo,DiaDaSemana.Segunda,DiaDaSemana.Terca, DiaDaSemana.Quarta,
                DiaDaSemana.Quinta, DiaDaSemana.Sexta, DiaDaSemana.Sabado
            };

            foreach (var item in DiaSemanaComEnum)
            {
                Console.WriteLine($"{item} Numero: { (int)item}");
            }

            /* DiaDaSemana hoje = DiaDaSemana.Terca;

             if (hoje == DiaDaSemana.Terca)
             {
                 Console.WriteLine($"Hoje é {DiaDaSemana.Terca}");
             }*/
        }

    }
}

    public enum DiaDaSemana
    {
        Domingo = 1,
        Segunda ,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }


