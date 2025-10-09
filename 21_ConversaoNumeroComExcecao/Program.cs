using System;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            string valorDigitado = Console.ReadLine();

            try
            {
                int numero = Convert.ToInt32(valorDigitado);
                int dobro = numero * 2;
                Console.WriteLine($"O dobro de {numero} é {dobro}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
