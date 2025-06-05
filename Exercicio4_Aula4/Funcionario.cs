using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Aula4
{
    internal class Funcionario
    {
        public Funcionario(string nome, string cargo, int salario) 
        { 
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        private string nome { get; set; }
        private string cargo { get; set; }
        public int salario { get; private set;}

        public void Exibir()
        {
            Console.WriteLine($"Nome: {this.nome} - Cargo: {this.cargo} - Salário R$: {this.salario}");  
        }
    }
}
