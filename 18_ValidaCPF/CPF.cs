using System;
using System.Linq;
using System.Text.RegularExpressions;
using _18_ValidaCPF;

public class CPF : IDocumento//segue a interface
{
    public string Numero { get; private set; }

    public CPF(string numero)
    {
        // Remove tudo que não é número
        Numero = Regex.Replace(numero, "[^0-9]", "");
    }

    public bool Validar()//método da interface obrigatorio implementar
    {
        // Verifica se tem 11 dígitos
        if (Numero.Length != 11)
            return false;

        // Verifica se todos os números são iguais
        if (Numero.Distinct().Count() == 1)
            return false;

        // Calcula os dígitos verificadores
        int digX = CalculaDV(Numero, 9, 10);
        int digY = CalculaDV(Numero, 10, 11);

        return int.Parse(Numero[9].ToString()) == digX &&
               int.Parse(Numero[10].ToString()) == digY;
    }

    private int CalculaDV(string cpf, int qtdeNumeros, int peso)
    {
        int soma = 0;
        char[] cpfVetor = cpf.ToCharArray();

        for (int i = 0; i < qtdeNumeros; i++)
        {
            soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);
        }

        int resto = soma % 11;
        return resto >= 2 ? 11 - resto : 0;
    }
}
