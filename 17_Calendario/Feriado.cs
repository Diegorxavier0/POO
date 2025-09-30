using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado
    {
        public int Dia { get; set; }
        public string Descricao { get; set; }

        public Feriado(int dia, string descricao)
        {
            this.Dia = dia;
            this.Descricao = descricao;
        }
    }
}