using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    internal class CNPJ : IDocumento
    {
        public string Numero { get; }

        public CNPJ(string numero)
        {
            this.Numero = Regex.Replace(numero, "[^0-9]", "");
        }

        public bool Validar()
        {
            // Verifica se o CNPJ tem 14 dígitos
            if (this.Numero.Length != 14)
                return false;

            // Verifica se o CNPJ tem todos os números iguais
            if (this.Numero.Distinct().Count() == 1)
                return false;

            // Calcula o 1º dígito verificador
            int digX = CalculaDV(this.Numero, 12, 5);

            // Calcula o 2º dígito verificador
            int digY = CalculaDV(this.Numero, 13, 6);

            // Compara os dígitos verificadores
            if (
                int.Parse(this.Numero[12].ToString()) == digX &&
                int.Parse(this.Numero[13].ToString()) == digY
               )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculaDV(string cnpj, int qtdeNumeros, int peso)
        {
            int soma = 0;
            char[] cnpjVetor = cnpj.ToCharArray();

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cnpjVetor[i].ToString()) * (peso - i);
            }
            int resto = soma % 11;

            int digito = 0;
            if (resto >= 2)
            {
                digito = 11 - resto;
            }
            return digito;
        }
    }
}