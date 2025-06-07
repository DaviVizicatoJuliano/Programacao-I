using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNet
{
    internal class Estoque
    {
        Produto[] produto = new Produto[5];
        private int contador = 0;

        public void Cadastrar(string nome, int quantidade, double valor)
        {
            if (contador < produto.Length)
            {
                produto[contador] = new Produto(nome, quantidade, valor);
                contador++;
            }
            else {
                Console.WriteLine("Limite Atingido");
            }
        }

        public void ListarTodos()
        {
            foreach (Produto p in produto)
            {
                if (p != null)
                    p.Exibir();
            }
        }
    }
}
