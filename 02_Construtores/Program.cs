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

            Quadrado quadrado = new Quadrado(); //

            quadrado.ImprimirArea();

            Quadrado quadrado1 = new Quadrado(10); //

            quadrado1.ImprimirArea();

            Retangulo retangulo = new Retangulo(7, 8);

            retangulo.ImprimirArea();

            Triangulo triangulo = new Triangulo(9, 10);

            triangulo.ImprimirArea();

        }


    }

    public class Quadrado

    {

        //modificador de acesso Private

        //pode ser usado apenas dentro da Classe

        private int Lado; //Atributo

        //Overload (Sobrecarga) de Cosnstrutor

        //Declarar mais de um construtor com a lista de argumentos diferentes

        public Quadrado()

        {

            this.Lado = 5;

        }

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

    public class Retangulo

    {

        private int Base, Altura;

        public Retangulo(int Base, int Altura)

        {

            this.Altura = Altura;

            this.Base = Base;

        }

        public int CalculaArea()

        {

            return Base * Altura;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Retangulo com lado de {Base} e altura de {Altura} possui uma área de {CalculaArea()}");

        }

    }

    public class Triangulo

    {

        private int Base, Altura;

        public Triangulo(int Base, int Altura)

        {

            this.Altura = Altura;

            this.Base = Base;

        }

        public int CalculaArea()

        {

            return (Base * Altura) / 2;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Triangulo com lado de {Base} e altura de {Altura} possui uma área de {CalculaArea()}");

        }

    }

}

