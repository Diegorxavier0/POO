using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj1.Lado = 25;
            obj1.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Largura = 10;
            obj3.Altura = 5;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 7;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Base = 8;
            obj5.Altura = 6;
            obj5.ImprimeArea();
        }
    }

    public class Quadrado
    {
        public int Lado;
        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }
     public class Retangulo
     { 
            public int Largura;
            public int Altura;

            public int CalculaArea()
            {
                int area = Largura * Altura;
                return area;
            }
            public void ImprimeArea()
            {
                Console.WriteLine($"Retângulo com largura de {Largura} e altura de {Altura} possui uma área de {CalculaArea()}");
            }
     }
    public class Circulo
    {
        public double Raio;
        public double CalculaArea()
        {
            double area = Math.PI * Raio * Raio;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma área de {CalculaArea():F2}");
        }
    }
    public class Triangulo
    {
        public double Base;
        public double Altura;
        public double CalculaArea()
        {
            double area = (Base * Altura) / 2.0;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma área de {CalculaArea():F2}");
        }
    }

}
