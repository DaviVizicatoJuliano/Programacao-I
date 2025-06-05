using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            int op;

            do { 
                Console.WriteLine("Sistema de Cadastro de Produto \n 1.Cadastrar Produto \n 2. Listar Produto \n 3. Atualizar Produto \n 4. Sair");
                Console.Write("Insira sua opção");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 1:
                        Console.WriteLine("Cadastro de Produtos");
                        Console.Write("Insira o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Insira a quantidade: ");
                        int quantidade = int.Parse(Console.ReadLine());
                        Console.Write("Insira o preço: ");
                        double preco = double.Parse(Console.ReadLine());
                        estoque.Cadastrar(nome, quantidade,preco);
                        break;

                    case 2:
                        Console.WriteLine("Todos os Funcionários");
                        estoque.Listar();
                        break;
                       
                    case 3:
                        Console.Write("Insira o nome do produto que quer atualizar: ");
                        string nomeprod = Console.ReadLine().ToLower();
                        Console.WriteLine("Insira a nova quantidade: ");
                        int novaquantidade = int.Parse(Console.ReadLine());
                        estoque.Atualizar(nomeprod, novaquantidade);
                        break;

                }
            } while (op != 4);
        }
    }
}
