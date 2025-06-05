using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06
{
    internal class Program
    {
        //Não Permite Herança
        public sealed class Utilitario {
            public int a {  get; set; }
            public void Exibir()
            {
                Console.WriteLine("Teste de Sealed");
            }
        }
        /*
        class Calculadora
        {
            public int somar(int a, int b)
            {
                return a + b;
            }

            public double somar(double a, double b)
            {
                return a * b;
            }

            public int somar(int a, int b, int c)
            {
                return a + b + c;
            }

            public int somar()
            {
                int a, b;
                Console.Write("Informe A: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Informe B: ");
                b = int.Parse(Console.ReadLine());
                return a+ b;
            }
        }*/
        static void Main(string[] args)
        {
            /*
            Calculadora calc = new Calculadora();
            Console.WriteLine("Soma: " + calc.somar(4, 8));
            Console.WriteLine("Overload Multiplicação: " + calc.somar(4.0, 8.0));
            Console.WriteLine("Overload Soma: " + calc.somar(4, 8, 2));
            Console.WriteLine("Overload Soma com inserção: " + calc.somar());*/


        }
    }
}
