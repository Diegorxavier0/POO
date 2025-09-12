using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_PropriedadesAteNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();
            Conta conta = new Conta("999-88");

            conta.Nome = ("Diego Xavier");

            //Não é possível atribuir o valor em um atributo privado
            //conta.Numero = "999-88";nao permite mais alterar o numero da conta, pois so tem o get e nao o set 

            //conta.saldo = -1000.00m;
            conta.Depositar(-1000.00m);

            //Utilizando o metodo acessador
            conta.Saldo= (1000.00m);//usando a propriedade e acessando membro public
            //Console.WriteLine($"Saldo Atual: {conta.getSaldo():c2}");
            conta.ImprimirSaldo();

            while (true)
            {
                //conta.numero = "777-66";
                Console.WriteLine("Informe a Operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.Numero} Nome: {conta.Nome} Saldo: {conta.Saldo:c2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }
    }
    public class Conta
    {
        private string numero;

        public string Numero { get; }//propriedade somente leitura


        private string nome;

        public string Nome { get; set; } //propriedade com acesso publico

        public Conta(string numero)
        {
            this.numero = numero;
        }

        //Transformar a conta Saldo com acesso privado
        //public decimal Saldo;        
        private decimal saldo;

        //declaração da propriedade

        //declaração da propriedade ate a versao 8 do .net
        public decimal Saldo
        {
            get { return saldo; }
            set
            { 
            this.Depositar( value);
            }
        }

        //métodos acessadores
        //public decimal getSaldo()
        //{
        //    return saldo;
        //}

        //public void setSaldo(decimal saldo)
        //{
        //    this.Depositar(saldo);
        //}

        //public string getNumero()
        //{
        //    return numero;
        //}

        //public string getNome()
        //{
        //    return nome;//pega o nome
        //}

        //public void setNome(string nome)
        //{
        //    this.nome = nome;//atribue o nome
        //}

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            //Console.WriteLine($"Saldo Atual: {getSaldo():c2}");
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }
    }
}




//using System;

//namespace _03_Propriedades
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Criando a conta passando número e nome pelo construtor
//            Conta conta = new Conta("999-88", "Diego Xavier");

//            // Teste de depósito negativo (vai mostrar mensagem de erro)
//            conta.Depositar(-1000.00m);

//            // Definindo saldo inicial usando método acessador
//            conta.setSaldo(1000.00m);

//            conta.ImprimirSaldo();

//            while (true)
//            {
//                Console.WriteLine("Informe a operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
//                string operacao = Console.ReadLine();

//                if (operacao.ToUpper() == "D")
//                {
//                    Console.WriteLine("Informe o valor para depósito: ");
//                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
//                    conta.Depositar(valorDeposito);
//                    conta.ImprimirSaldo();
//                }
//                else if (operacao.ToUpper() == "S")
//                {
//                    Console.WriteLine("Informe o valor para saque: ");
//                    decimal valorSaque = decimal.Parse(Console.ReadLine());
//                    conta.Sacar(valorSaque);
//                    conta.ImprimirSaldo();
//                }
//                else if (operacao.ToUpper() == "E")
//                {
//                    // Exibindo informações da conta antes de sair
//                    Console.WriteLine($"Conta: {conta.GetNumero()} Nome: {conta.Nome} Saldo: {conta.getSaldo():C2}");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S]-Sacar ou [E]-Sair");
//                }
//            }
//        }
//    }

//    public class Conta
//    {
//        // Campo privado para o número da conta
//        // ✅ Só pode ser definido no construtor, não pode ser alterado depois
//        private string numero;

//        // Nome do titular pode ser alterado
//        public string Nome { get; set; }

//        // Saldo privado, controlado pelos métodos
//        private decimal saldo;

//        // Construtor
//        // Define número da conta e nome do titular
//        public Conta(string numero, string nome)
//        {
//            this.numero = numero; // "this" garante que estamos atribuindo ao campo da classe
//            Nome = nome;
//        }

//        // Método para retornar número da conta
//        public string GetNumero()
//        {
//            return numero;
//        }

//        // Métodos acessadores de saldo
//        public decimal getSaldo()
//        {
//            return saldo;
//        }

//        public void setSaldo(decimal saldo)
//        {
//            if (saldo >= 0)
//                this.saldo = saldo;
//            else
//                Console.WriteLine("Saldo não pode ser negativo!");
//        }

//        // Depositar valor positivo
//        public void Depositar(decimal valor)
//        {
//            if (valor > 0)
//                saldo += valor;
//            else
//                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
//        }

//        // Sacar valor se houver saldo suficiente
//        public void Sacar(decimal valor)
//        {
//            if (valor <= 0)
//                Console.WriteLine("Valor de saque inválido, deve ser maior que zero!");
//            else if (valor > saldo)
//                Console.WriteLine("Saldo insuficiente!");
//            else
//                saldo -= valor;
//        }

//        // Imprimir saldo atual
//        public void ImprimirSaldo()
//        {
//            Console.WriteLine($"Saldo Atual: {saldo:C2}");
//        }
//    }
//}
