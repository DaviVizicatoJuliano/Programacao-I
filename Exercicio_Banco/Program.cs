using System;

namespace Exercicio_Banco
{
    internal class Program
    {
        class Conta
        {
            protected int nro_conta;
            protected double saldo;

            public Conta(int nro_conta, double saldo)
            {
                this.nro_conta = nro_conta;
                this.saldo = saldo;
            }

            public void Depositar()
            {
                Console.Write("Quantidade que deseja depositar: ");
                double quant = double.Parse(Console.ReadLine());
                saldo += quant;
                Console.WriteLine("Depósito realizado com sucesso!");
            }

            public virtual void Sacar()
            {
                Console.Write("Quantidade que deseja sacar: ");
                double quant = double.Parse(Console.ReadLine());

                if (saldo > 0 && saldo - quant > 0)
                {
                    saldo -= quant;
                    Console.WriteLine("Saque realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }

            public void VerSaldo()
            {
                Console.WriteLine($"Número da conta: {nro_conta} - Saldo: {saldo}");
            }
        }

        class ContaEspecial : Conta
        {
            private double limite;

            public ContaEspecial(int nro_conta, double saldo, double limite)
                : base(nro_conta, saldo)
            {
                this.limite = limite;
            }

            public override void Sacar()
            {
                Console.Write("Quantidade que deseja sacar: ");
                double quant = double.Parse(Console.ReadLine());
                saldo -= quant;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== BANCO DO DAVI ===");
            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o saldo inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            Console.Write("Conta especial? (s/n): ");
            string tipo = Console.ReadLine().ToLower();

            Conta conta;

            if (tipo == "s")
            {
                Console.Write("Informe o limite da conta especial: ");
                double limite = double.Parse(Console.ReadLine());
                conta = new ContaEspecial(numero, saldoInicial, limite);
            }
            else
            {
                conta = new Conta(numero, saldoInicial);
            }

            int opcao;
            do
            {
                Console.WriteLine("\n1 - Ver Saldo\n2 - Depositar\n3 - Sacar\n0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        conta.VerSaldo();
                        break;
                    case 2:
                        conta.Depositar();
                        break;
                    case 3:
                        conta.Sacar();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);

            Console.WriteLine("Obrigado por usar o Banco do Davi!");
        }
    }
}
