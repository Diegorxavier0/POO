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
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "123.456.789-00";
            pessoaFisica.Telefone = "(11) 91234-5678";
            pessoaFisica.Imprimir();

            //Testa o pessoa juridica
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Paletas Mexicanas";
            pessoaJuridica.CNPJ = "12.345.678/0001-00";
            pessoaJuridica.Telefone = "(014) 9875-4321";
            pessoaJuridica.Imprimir();


        }
    }
}
