using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"\nLISTA DE PESSOAS\n\nNome: {this.Nome} Documento {this.GetDocumento()} telefone: {this.Telefone}");

        }
    }
}    

