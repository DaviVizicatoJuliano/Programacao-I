using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula4
{
    internal class Livro
    {
        private string titulo {  get; set; }
        public string autor { get;  private set; }
        private int ano { get; set; }

        public Livro (string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
        }

        public void Exibir() {
            Console.WriteLine($"Titulo: {this.titulo} - Autor: {this.autor} - Ano: {this.ano}");
        }
    }
}
