using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class PessoaJuridica: Pessoa
    {
        public string CNPJ;
        public override string GetDocumento()
        {
            return $"CNPJ: {this.CNPJ}";
        }
    }
}
