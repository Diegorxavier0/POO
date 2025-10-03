using System;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia { get; set; }
        public string Descricao { get; set; }

        public Feriado(int dia, string descricao)
        {
            this.Dia = dia;
            this.Descricao = descricao;
        }

        // Implementação do IComparable para ordenar pelo Dia
        public int CompareTo(Feriado other)
        {
            if (other == null) return 1;
            //ORDEM CRESCENTE
            return this.Dia.CompareTo(other.Dia);

            //ORDEM DECRESCENTE
            //return other.Dia.CompareTo(this.Dia);
        }
    }
}
