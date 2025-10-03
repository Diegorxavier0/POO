using System;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tipo de documento (CPF/CNPJ): ");
            string tipo = Console.ReadLine().ToUpper();//ToUpper converte tudo para maiusculo cpf, CPF
            if (tipo != "CPF" && tipo != "CNPJ")
            {
                Console.WriteLine("Tipo inválido! Digite apenas CPF ou CNPJ.");
                return; // Sai do programa ou pode repetir a leitura
            }



            Console.Write("Digite o número: ");
            string numero = Console.ReadLine();
            if (!long.TryParse(numero, out _))
            {
                Console.WriteLine("Digite apenas números!");
                return; // Sai do programa ou volta para pedir novamente
            }

            IDocumento documento;

            if (tipo == "CPF")
                documento = new CPF(numero);
            else if (tipo == "CNPJ")
                documento = new CNPJ(numero);
            else
            {
                Console.WriteLine("Tipo de documento inválido!");
                return;
            }

            if (documento.Validar())
                Console.WriteLine($"{tipo} VÁLIDO!");
            else
                Console.WriteLine($"{tipo} INVÁLIDO!");
        }
    }
}
