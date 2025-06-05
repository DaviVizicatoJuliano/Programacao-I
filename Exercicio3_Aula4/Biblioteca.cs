using System;

namespace Exercicio3_Aula4
{
    internal class Biblioteca
    {
        Livro[] livro = new Livro[10];

        // Construtor para adicionar alguns livros de exemplo
        public Biblioteca()
        {
            livro[0] = new Livro("Dom Casmurro", "Machado de Assis",1999);
            livro[1] = new Livro("Memórias Póstumas", "Machado de Assis",2005);
            livro[2] = new Livro("A Hora da Estrela", "Clarice Lispector", 1990);
        }

        public void BuscaPorAutor()
        {
            Console.Write("Insira o nome do autor: ");
            string nomeautor = Console.ReadLine().ToLower();

            bool encontrado = false;

            for (int i = 0; i < livro.Length; i++)
            {
                if (livro[i] != null && livro[i].autor.ToLower().Contains(nomeautor))
                {
                    livro[i].Exibir();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nenhum livro encontrado para esse autor.");
            }
        }
    }
}
