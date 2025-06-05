using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Serjao
{
    internal class Program
    {
        public class Livro
        {
            public string titulo;
            public string autor;

            public void ExibirDados()
            {
                Console.WriteLine($"Titulo do Livro: {this.titulo} - Autor: {this.autor}");
            }

            public Livro()
            {
                Console.Write("Escreva o Título do Livro: ");
                this.titulo = Console.ReadLine();
                Console.Write("Escreva o Autor: ");
                this.autor = Console.ReadLine();
            }
        }
        static void Main(string[] args) 
        {
            Livro[] livro = new Livro[3];

            livro[0] = new Livro();
            livro[1] = new Livro();
            livro[2] = new Livro();

            foreach (var livroatual in livro)
            {
                livroatual.ExibirDados();
            }
        }
    }
}
