using System;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando a conta passando número e nome pelo construtor
            Conta conta = new Conta("999-88", "Diego Xavier");

            // Teste de depósito negativo (vai mostrar mensagem de erro)
            conta.Depositar(-1000.00m);

            // Definindo saldo inicial usando método acessador
            conta.setSaldo(1000.00m);

            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
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
                    // Exibindo informações da conta antes de sair
                    Console.WriteLine($"Conta: {conta.GetNumero()} Nome: {conta.Nome} Saldo: {conta.getSaldo():C2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S]-Sacar ou [E]-Sair");
                }
            }
        }
    }

    public class Conta
    {
        // Campo privado para o número da conta
        // ✅ Só pode ser definido no construtor, não pode ser alterado depois
        private string numero;

        // Nome do titular pode ser alterado
        public string Nome { get; set; }

        // Saldo privado, controlado pelos métodos
        private decimal saldo;

        // Construtor
        // Define número da conta e nome do titular
        public Conta(string numero, string nome)
        {
            this.numero = numero; // "this" garante que estamos atribuindo ao campo da classe
            Nome = nome;
        }

        // Método para retornar número da conta
        public string GetNumero()
        {
            return numero;
        }

        // Métodos acessadores de saldo
        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            if (saldo >= 0)
                this.saldo = saldo;
            else
                Console.WriteLine("Saldo não pode ser negativo!");
        }

        // Depositar valor positivo
        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        // Sacar valor se houver saldo suficiente
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
                Console.WriteLine("Valor de saque inválido, deve ser maior que zero!");
            else if (valor > saldo)
                Console.WriteLine("Saldo insuficiente!");
            else
                saldo -= valor;
        }

        // Imprimir saldo atual
        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo Atual: {saldo:C2}");
        }
    }
}
