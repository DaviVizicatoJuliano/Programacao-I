using System;

namespace Exercicios_interface
{
    // ESTRUTURA CORRIGIDA:
    // As classes e a interface agora estão aqui, no nível do namespace,
    // e não dentro da classe Program.

    public class Banco
    {
        protected string nome { get; set; }
        protected double saldo { get; set; }
        public Banco(string nome)
        {
            this.nome = nome;
        }
    }

    public interface Iconta
    {
        void depositar(double valor);
        void sacar(double valor);
        double GetSaldo();
    }

    public class ContaCorrente : Banco, Iconta
    {
        double tarifa = 1.50;

        public ContaCorrente(string nome, double saldo) : base(nome)
        {
            this.saldo = saldo;
        }

        public void sacar(double valor)
        {
            if (saldo >= valor + tarifa)
            {
                Console.WriteLine($"\nSaque na C/C no valor de {valor} (tarifa de {tarifa})");
                saldo = saldo - valor - tarifa;
                Console.WriteLine($"Cliente : {nome} - Saldo restante: {GetSaldo()}");
            }
            else
            {
                Console.WriteLine("\nSaldo Insuficiente na C/C!");
            }
        }
        public void depositar(double valor)
        {
            Console.WriteLine($"\nDepósito na conta corrente no valor de: {valor}");
            saldo += valor;
            Console.WriteLine($"Cliente : {nome} - Saldo restante: {GetSaldo()}");
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }

    public class ContaPoupança : Banco, Iconta
    {
        public ContaPoupança(string nome, double saldo) : base(nome)
        {
            this.saldo = saldo;
        }

        public void depositar(double valor)
        {
            Console.WriteLine($"\nDepósito na poupança no valor de: {valor}");
            saldo += valor;
            Console.WriteLine($"Cliente: {nome} - Saldo da poupança: {GetSaldo()}");
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void sacar(double valor)
        {
            if (saldo >= valor)
            {
                Console.WriteLine($"\nSaque na poupança no valor de {valor}");
                saldo -= valor;
                Console.WriteLine($"Cliente: {nome} - Saldo da poupança: {GetSaldo()}");
            }
            else
            {
                Console.WriteLine("\nSaldo Insuficiente na poupança!");
            }
        }
    }

    public class GeradordeExtratos
    {
        public void GerarExtrato(Iconta conta)
        {
            double saldoAtual = conta.GetSaldo();
            Console.WriteLine($"Saldo disponível: {saldoAtual}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente("Davi", 100);
            c1.depositar(120);
            c1.sacar(100);

            ContaPoupança c2 = new ContaPoupança("Luan", 200);
            c2.depositar(100);
            c2.sacar(50);

            GeradordeExtratos gerador = new GeradordeExtratos();

            Console.Write("Extrato do Davi: ");
            gerador.GerarExtrato(c1);

            Console.Write("Extrato do Luan: ");
            gerador.GerarExtrato(c2);
        }
    }
}