using System;

namespace AulaPreProva
{
    internal class Program
    {
        public class Produto
        {
            public string Nome { get; private set; }
            public double Preco { get; private set; }
            public int Quantidade { get; private set; }

            public Produto(string nome, int quantidade, double preco)
            {
                Nome = nome;
                Quantidade = quantidade;
                Preco = preco;
            }

            public void Exibir()
            {
                Console.WriteLine($"Produto: {Nome} - Quantidade: {Quantidade} - Preço: {Preco}");
            }

            public double CalcularTotal()
            {
                return Quantidade * Preco;
            }
        }

        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[3];
            int contador = 0;
            int op;

            do
            {
                Console.WriteLine("\n1. Cadastrar \n2. Listar \n3. Sair");
                Console.Write("Escolha a opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        break;

                    case 2:
                        if (contador == 0)
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < contador; i++)
                            {
                                Console.Write($"{i + 1}. ");
                                produtos[i].Exibir();
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            } while (op != 3);
        }
    }
}
