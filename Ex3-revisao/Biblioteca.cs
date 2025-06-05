using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_revisao
{
    internal class Biblioteca
    {
        Livro[] livro = new Livro[3];
        private int contador = 0;
        public void Cadastrar (string nome, string autor)
        {
            if (contador < livro.Length)
            {
                livro[contador] = new Livro(nome,autor);
                contador++;
            }else
            {
                Console.WriteLine("LIMITE!");
            }
        }

        public void ListarTodos()
        {
            foreach (Livro l in livro)
            {
                l.Exibir();
            }
        }
    }
}
