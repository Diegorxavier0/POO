using System;

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
            obj2.Lado = 25;
            obj2.ImprimeArea();

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

            Conta obj6 = new Conta();
            obj6.Banco = 260;       //Banco
            obj6.Agencia = "0001";
            obj6.Numero = "12345-6";
            obj6.Saldo = 2000;
            obj6.Limite = 500;

            obj6.ConsultaSaldo();
            obj6.Depositar(200);
            obj6.Sacar(300);

            Aluno obj7 = new Aluno();
            obj7.Codigo = 1;
            obj7.Nome = "Ana Silva";
            obj7.LancarNota(9.6, 8.0,9.5,10.0);//ARRUMAR NA AULA 
            obj7.CalculaMedia();
            obj7.Mencao();

        }
    }

    public class Quadrado
    {
        public int Lado;
        public int CalculaArea()
        {
            return Lado * Lado;
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
            return Largura * Altura;
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
            return Math.PI * Raio * Raio;
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
            return (Base * Altura) / 2.0;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma área de {CalculaArea():F2}");
        }
    }

    public class Conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

        public void Depositar(double valor)
        {
            // OS DOIS SÃO A MESMA COISA  Saldo = Saldo + valor;
            Saldo += valor;
            //Console.WriteLine($"Depósito de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }

        public void Sacar(double valor)
        {
            if (Saldo + Limite >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public double ConsultaSaldo()
        {
            return Saldo;
            //Console.WriteLine($"Conta {Numero} do banco {Banco} possui saldo de {Saldo:C} e limite de {Limite:C}");
        }
    }
    public class Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];
        public void LancarNota(int trimestre, double nota)
        {
            Notas[trimestre -1] = nota;//-1 porque no vetor ele precisar se iniciar com 0, por isso subtrair -1
           
        }
        public double CalculaMedia()
        {
            double media = 0;

            foreach (double nota in Notas)
            { 
                media += nota;
            }

            return media/4.0;
            
        }
        public string Mencao()
        {
          
            if (CalculaMedia() >= 5.0)
                return "Aprovado";
            else
                return "Reprovado";
        }
    };
}
