using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex5_revisao.Program;

namespace Ex5_revisao
{
    internal class Program
    {
        public class Funcionario
        {
            private string nome {  get; set; }
            private double salario { get; set; }

            public Funcionario ()
            {
                Console.Write("Insira o nome: ");
                this.nome = Console.ReadLine();
                Console.Write("Insira o salario: ");
                this.salario = double.Parse(Console.ReadLine());
            }

            public string VerificarSalario()
            {
                if (salario > 3000)
                {
                    return "Salario Acima";
                }
                return "salario abaixo";
            }

            public void Exibir()
            {
                Console.WriteLine($"Nome: {this.nome} - Salario: {this.salario} - Verificação : {VerificarSalario()}");
            }
        }

        static void Main(string[] args)
        {
            Funcionario[] funcionarios = new Funcionario[5]; 
            int opcao;
            int contador = 0;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1 - Adicionar Funcionário");
                Console.WriteLine("2 - Listar Funcionários");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                // Validação simples
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Digite um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        
                        if (contador < funcionarios.Length)
                        {
                            funcionarios[contador] = new Funcionario();
                            contador++;
                        }else
                        {
                            Console.WriteLine("Limite");
                        }  
                        break;

                    case 2:
                        Console.WriteLine("\n--- Lista de Funcionários ---");

                        for (int i = 0; i < funcionarios.Length; i++)
                        {
                            funcionarios[i].Exibir();
                        }
                        
                        break;

                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 0);
        
    } 
    }
}
