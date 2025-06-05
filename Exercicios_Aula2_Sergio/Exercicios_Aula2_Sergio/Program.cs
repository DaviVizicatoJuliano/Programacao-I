using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Aula2_Sergio
{
    internal class Program
    {
        public class Livro
        {
            string titulo;
            string autor;

            public void MostrarDetalhes()
            {
                Console.WriteLine($"Título do Livro: {this.titulo} - Autor: {this.autor}");
            }

            public Livro() {
                Console.Write("Escreva o Nome do Livro: ");
                this.titulo = Console.ReadLine();
                Console.Write("Escreva o Autor: ");
                this.autor = Console.ReadLine();    
            }
        }

        public class Filme
        {
            public string titulo;
            public int anolanc;

            public void MostrarDetalhes()
            {
                Console.WriteLine($"Título do Filme: {this.titulo} - Ano de Lançamento: {this.anolanc}");
            }

            public Filme()
            {
                Console.Write("Escreva o Nome do Filme: ");
                this.titulo = Console.ReadLine();
                Console.Write("Escreva o Ano de Lançamento: ");
                this.anolanc = int.Parse( Console.ReadLine() );

            }
        }

        public class Cidade
        {
            public string nome;
            public string estado;
            public void ExibirCidade()
            {
                Console.WriteLine($"Nome da Cidade : {this.nome} - Estado: {this.estado}");
            }

            public Cidade()
            {
                Console.Write("Escreva o Nome da Cidade: ");
                this.nome = Console.ReadLine();
                Console.Write("Escreva o Ano de Lançamento: ");
                this.estado = Console.ReadLine();
            }
        }

        public class Musica
        {
            public string titulo;
            public string cantor;

            public void Tocar()
            {
                Console.WriteLine($"A musica {this.titulo} é cantada por {this.cantor}");
            }


            public Musica()
            {
                Console.Write("Escreva o Nome da Musica: ");
                this.titulo = Console.ReadLine();
                Console.Write("Escreva o Cantor: ");
                this.cantor = Console.ReadLine();
            }
        }

        class Pessoa
        {
            public string name { get; set; }
            public int idade { get; set; }
            public void Apresentar()
            {
                Console.WriteLine($"Olá me chamo {this.name} e tenho {this.idade} anos");
            }
            public Pessoa()
            {
                Console.Write("Escreva seu nome: ");
                this.name = Console.ReadLine();
                Console.Write("Escreva sua idade: ");
                this.idade = int.Parse(Console.ReadLine());
            }
        }

        class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Nome do Aluno: {this.Nome} - Nota: {this.Nota}");
            }

            public Aluno()
            {
                Console.Write("Escreva o nome do aluno: ");
                this.Nome = Console.ReadLine();

                Console.Write("Escreva a nota do aluno: ");
                this.Nota = Convert.ToDouble(Console.ReadLine());
            }

        }

        class Retangulo
        {
            public double Altura { get; set; }
            public double Largura { get; set; }
            public double AreaRetangulo { get; set; }

            public void CalcularArea()
            {
                AreaRetangulo = this.Altura * this.Largura;
                Console.WriteLine("Area do Triangulo: " + AreaRetangulo);
            }

            public Retangulo()
            {
                Console.WriteLine("Insira a Altura: ");
                this.Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira a Largura: ");
                this.Largura = Convert.ToDouble(Console.ReadLine());
            }
        }

            static void Main(string[] args)
        {
            /*
            Exercicio 1
            Instanciar seria criar um objeto através da classe criada anteriormente, como por exemplo
            criar uma classe carro e instanciar o carro como cor, modelo e ano
            */

            /*
            //Exercicio 2
            Livro L1 = new Livro();
            L1.MostrarDetalhes();
            */

            /*
            //Exercicio 3
            Filme F1 = new Filme();
            F1.MostrarDetalhes();
            */

            /*
            //Exercicio 4
            Cidade C1 = new Cidade();
            C1.ExibirCidade();
            */

            /*
            //Exercicio 5
            Musica M1 = new Musica();
            M1.Tocar();
            */

            /*
            //Exerciocio 6
            Pessoa pessoa = new Pessoa();
            pessoa.Apresentar();
            */

            /*
            //Exercicio 7
            Produto product = new Produto();
            product.ExibirInformacoes();
            */

            /*
            //Exercicio 8
            Aluno aluno = new Aluno();        
            aluno.ExibirInformacoes();
            */

            Retangulo retangulo = new Retangulo();
            retangulo.CalcularArea();
        }
    }
}
