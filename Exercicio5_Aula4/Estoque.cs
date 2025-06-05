using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Aula4
{
    internal class Estoque
    {
        private Produto[] produto = new Produto[5];
        private int contador = 0;

        public void Cadastrar(string nome, int quantidade, double preco)
        {
            if (contador < produto.Length)
            {
                produto[contador] = new Produto(nome, quantidade, preco);
                contador++;
            }
            else
            {
                Console.WriteLine("Maximo Atingido");
            }
        }

        public void Atualizar (string nomeprod, int novaquantidade)
        {
            
            for (int i = 0; i < produto.Length; i++)
            {
                if (produto[i] != null && produto[i].nome.ToLower().Contains(nomeprod))
                {
                    produto[i].quantidade = novaquantidade;
                }
            }

        }

        public void Listar()
        {
            for (int i = 0; i < produto.Length; i++)
            {
                if (produto[i] != null)
                {
                    produto[i].Exibir();
                }
            }
        }
    }
}
