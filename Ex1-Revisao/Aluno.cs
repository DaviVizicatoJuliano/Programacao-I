using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Revisao
{
    internal class Aluno
    {
        private string nome {  get; set; }
        private double nota { get; set; }

        public Aluno(string nome, double nota)
        {
            this.nome = nome;
            this.nota = nota;
        }

        public void Exibir ()
        {
            Console.WriteLine($" Nome Aluno: {this.nome} - Nota: {this.nota}");
        }
    }
}
