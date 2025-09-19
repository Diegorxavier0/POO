using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class PessoaFisica: Pessoa
    {
        public string CPF;

        public override string GetDocumento()
        {
            return $"CPF: {this.CPF}";
        }
    }
}
