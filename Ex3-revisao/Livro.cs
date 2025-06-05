using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_revisao
{
    internal class Livro
    {
        private string nome {  get; set; }
        private string autor {  get; set; }

        public Livro(string nome, string autor)
        {
            this.nome = nome;
            this.autor = autor;
        }

        public void Exibir()
        {
            Console.WriteLine($"Livro : {this.nome} - Autor: {this.autor}");
        }
    }
}
