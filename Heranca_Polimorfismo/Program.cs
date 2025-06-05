using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Poliformismo
{
    internal class Program
    {
        class Funcionario
        {
            public string nome {  get; set; }
            public double salario { get; set; }

            public Funcionario(string nome, double salario) {
                this.nome = nome;
                this.salario = salario;
            }

            public virtual void CalcularBonus()
            {
                int percentual = 0;
                double aumento = salario * percentual / 100;
                double salarioreal = salario + aumento;
                Console.WriteLine("Novo Salario: " + salarioreal);
            }
        }

        class Gerente : Funcionario {

            public Gerente (string nome, double salario) : base(nome, salario) { }
            public override void CalcularBonus()
            {
                int percentual = 15;
                double aumento = salario * percentual / 100;
                double salarioreal = salario + aumento;
                Console.WriteLine("Novo Salario: " + salarioreal);
            }
        }

        class Vendedor : Funcionario
        {
            public Vendedor (string nome, double salario) : base(nome, salario)
            {
            }

            public override void CalcularBonus()
            {
                int percentual = 10;
                double aumento = salario * percentual / 100;
                double salarioreal = salario + aumento;
                Console.WriteLine("Novo Salario: " + salarioreal);
            }
        }
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Lucas", 1000);
            Gerente g1 = new Gerente("Fernando", 1000);
            Vendedor v1 = new Vendedor("Fabiano", 1000);
            f1.CalcularBonus();
            g1.CalcularBonus();
            v1.CalcularBonus();
        }
    }
}
