using System;

enum DiaDaSemana
{
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
}

class Program
{
    static void Main(string[] args)
    {
        DiaDaSemana hoje = DiaDaSemana.Terca;

        if (hoje == DiaDaSemana.Terca)
        {
            Console.WriteLine($"Hoje é {DiaDaSemana.Terca}");
        }
    }
}
