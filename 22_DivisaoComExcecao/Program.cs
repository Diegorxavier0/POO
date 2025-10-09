using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Digite o 1° Número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o 2° Número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultado = num1 / num2;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("O número digitado não é um número inteiro:");
            }
            finally
            {
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o programa!");
            }
        }
    }
}
