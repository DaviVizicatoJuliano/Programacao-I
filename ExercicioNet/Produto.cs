using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNet
{
    internal class Produto
    {
        private string nome {  get; set; }
        private int quantidade {  get; set; }
        private double preco { get; set; }

        public Produto (string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {this.nome} - Quantidade: {this.quantidade} - Preço: {this.preco}");
        }
    }
}
