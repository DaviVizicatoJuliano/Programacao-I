using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNet
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            int op;

            while (true) {

                Console.Write("1.Cadastrar \n 2.Lista Todos \n 3.Sair \n Insira sua opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 1:
                        Console.Write("Qual o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Qual a quantidade: ");
                        int quantidade = int.Parse(Console.ReadLine());
                        Console.Write("Insira o preço: ");
                        double preco = double.Parse(Console.ReadLine());
                        estoque.Cadastrar(nome, quantidade, preco); 
                        break;

                    case 2:
                        estoque.ListarTodos();
                        break;

                    case 3:
                        return;
                }
            }
        }
    }
}
