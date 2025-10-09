using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota de 0 a 10: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (nota < 0 || nota > 10)
                {
                    throw new NotaInvalidaException();
                }
                else
                {
                    Console.WriteLine($"A nota digitada foi: {nota}");
                }

                if (nota >= 5)
                {
                    Console.WriteLine("Aprovado!");
                }
                else
                {
                    Console.WriteLine("Reprovado!");
                }
            }
            catch (NotaInvalidaException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
