using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _18_ValidaCPF
{
    public class CNPJ : IDocumento
    {
        public string Numero { get; private set; }

        public CNPJ(string numero)
        {
            // Remove tudo que não é número
            Numero = Regex.Replace(numero, "[^0-9]", "");
        }

        public bool Validar()
        {
            // Deve ter 14 dígitos
            if (Numero.Length != 14)
                return false;

            // Verifica se todos os números são iguais
            if (Numero.Distinct().Count() == 1)
                return false;

            int digX = CalculaDV(Numero, 12, 5);
            int digY = CalculaDV(Numero, 13, 6);

            return int.Parse(Numero[12].ToString()) == digX &&
                   int.Parse(Numero[13].ToString()) == digY;
        }

        private int CalculaDV(string cnpj, int qtdeNumeros, int pesoInicial)
        {
            int soma = 0;
            int peso = pesoInicial;

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cnpj[i].ToString()) * peso;
                peso--;
                if (peso < 2)
                    peso = 9;
            }

            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }
}
