using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulaPreProva
{
    internal class Program
    {
        public class Produto
        {
            private string nome { get; set; }
            private double preco { get; set; }
            private int quantidade { get; set; }

            public Produto(string nome,int quantidade, double preco)
            {
                this.nome = nome;
                this.quantidade = quantidade;
                this.preco = preco;      
            }

            public void Exibir()
            {
                Console.WriteLine($"Preço: {this.preco} - Produto: {this.nome} - Quantidade: {this.quantidade} - Calculo total:  {Calcular()}");
            }

            public double Calcular()
            {
                double sum = 0;

                sum = quantidade * preco;
                return sum;
            }     
        }
        static void Main(string[] args)
        {
            Produto[] produto = new Produto[3];
            int op;
            do
            {
                Console.WriteLine("1.Cadastrar \n 2.Listar \n 3.Sair");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 1:
                        for (int i = 0; i < 3; i++) {
                            Console.Write("Insira o nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.Write("Insira a quantidade: ");
                            int quantidade = int.Parse(Console.ReadLine());
                            Console.Write("Insira o preço: ");
                            double preco = Convert.ToDouble(Console.ReadLine());
                            produto[i] = new Produto(nome, quantidade, preco); 
                        }
                        break;

                    case 2:
                        Console.WriteLine("Escolha o Produto");
                        for (int i = 0;i < 3; i++)
                        {
                            produto[i].Exibir();
                        }
                        break;

                }
            }while(op != 3);
        }
    }
}
