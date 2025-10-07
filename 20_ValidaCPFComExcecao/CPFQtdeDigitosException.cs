using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using _20_ValidaCPFComExecao;

namespace _20_ValidaCPFComExcecao
{
    public class CPFQtdeDigitosException : Exception
    {
        public CPFQtdeDigitosException() : base("O CPF dever ter 11 dígitos!") { }
    }
}