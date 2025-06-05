using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            int op;
            do
            {
                Console.WriteLine("Sistema de Cadastro de Aluno \n 1.Cadastrar Aluno \n 2.Listar Alunos \n 3.Sair");
                Console.Write("Escolha a opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Console.Write("Nome do Livro: ");
                        string nome = Console.ReadLine();
                        Console.Write("Nome autor: ");
                        string autor = Console.ReadLine();
                        biblioteca.Cadastrar(nome, autor);
                        break;

                    case 2:
                        biblioteca.ListarTodos();
                        break;
                }
            } while (op != 3);
        }
    }
}
