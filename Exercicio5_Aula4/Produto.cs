using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Aula4
{
    internal class Produto
    {
        public string nome { get; private set; }
        public int quantidade { private get; set; }
        private double preco { get; set; }

        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {this.nome} - Quantidade: {this.quantidade} - Preço R$: {this.preco}");
        }
    }
}
