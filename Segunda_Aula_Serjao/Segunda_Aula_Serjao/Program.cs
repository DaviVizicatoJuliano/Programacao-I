using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_Aula_Serjao
{
    internal class Program
    {
        //Create Classes here
        class Pessoa
        {
            public string name { get; set; }
            public int idade { get; set; }
            public void Apresentar()
            {
                Console.WriteLine($"Olá me chamo {this.name} e tenho {this.idade} anos");
            }

            public void DateNas()
            {
                int resposta = 2025 - this.idade;
                Console.WriteLine("Idade da pessoa: " + resposta );
            }

            public Pessoa()
            {
                Console.Write("Escreva seu nome: ");
                this.name = Console.ReadLine();
                Console.Write("Escreva sua idade: ");
                this.idade = int.Parse( Console.ReadLine());
            }
        }
        
        
        static void Main(string[] args)
        {
            Pessoa P1 = new Pessoa();
            P1.Apresentar();
            P1.DateNas();
        }
    }
}
