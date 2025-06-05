using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma();
            int op;
            do
            {
                Console.WriteLine("Sistema de Cadastro de Aluno \n 1.Cadastrar Aluno \n 2.Listar Alunos \n 3.Sair");
                Console.Write("Escolha a opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 1:
                        Console.Write("Nome do Aluno: ");
                        string nome = Console.ReadLine();
                        Console.Write("Nota do Aluno: ");
                        double nota = double.Parse(Console.ReadLine());
                        turma.Cadastrar(nome,nota);
                        break;

                    case 2:
                        turma.Listar();
                        break;
                }
            } while (op!=3);
        }
    }
}
