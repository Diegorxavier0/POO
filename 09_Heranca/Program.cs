using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nao é possivel instanciar uma classe abstrata


            //Testa o pessoa fisica

            Pessoa[] pessoas = new Pessoa[2];//Criação do vetor

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "123.456.789-00";
            pessoaFisica.Telefone = "(11) 91234-5678";
            pessoaFisica.Imprimir();

            //Testa o pessoa juridica
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Paletas Mexicanas";
            pessoaJuridica.CNPJ = "12.345.678/0001-00";
            pessoaJuridica.Telefone = "(014) 9875-4321";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica))
            {
                Console.WriteLine("\nÉ a mesma pessoa");
            }
            else
            {
                Console.WriteLine("Não é a mesma pessoa");
            }

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
