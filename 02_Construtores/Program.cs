using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace _02_Contrutores

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Quadrado quadrado = new Quadrado(5); //

            quadrado.ImprimirArea();

        }

    }

    public class Quadrado

    {

        //modificador de acesso Private

        //pode ser usado apenas dentro da Classe

        private int Lado; //Atributo

        public Quadrado(int Lado) //declaração do construtor (nunca tem retorno, ele  serve para instanciar um objeto e inicializar os atributos 

        {

            //this: acessa o membro(atributo e método) da clase

            this.Lado = Lado;

        }

        public int CalculaArea()

        {

            return Lado * Lado;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");

        }

    }

}

