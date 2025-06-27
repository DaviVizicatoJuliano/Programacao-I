using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26_04
{
    internal class Program
    {

        public abstract class FormaGeometrica
        {
            public double Base {  get; set; }
            public double altura { get; set; }

            public abstract double area();
            public abstract double perimetro();

        }

        public class Circulo : FormaGeometrica
        {
            double PI = 3.14;
            public double raio {  get; set; }
            public Circulo (double raio)
            {
                this.raio = raio;
            }
            public override double area()
            {
                Console.Write("Area do Circulo: ");
                return PI * (raio * raio);
            }

            public override double perimetro()
            {
                Console.Write("Perimetro do Circulo: ");
                return 2 * PI * raio;
            }
        }

        public class Triangulo : FormaGeometrica
        {
            public double hipotenusa { private get; set; }

            public Triangulo(double hipotenusa, double Base, double altura)
            {
                this.Base = Base;
                this.altura = altura;
                this.hipotenusa = hipotenusa;
            }

            public override double area()
            {
                Console.Write("Area de um Triangulo: ");
                return Base * (altura / 2);
            }

            public override double perimetro()
            {
                Console.Write("Perimetro de um Triangulo: ");
                return altura + Base + hipotenusa;
            }
        }
        public class Retangulo : FormaGeometrica
        {
            public Retangulo(double altura, double Base)
            {
                this.Base = Base;
                this.altura = altura;
            }
            public override double area()
            {
                Console.Write("Area de um Retangulo: ");
                return Base * altura;
            }

            public override double perimetro()
            {
                Console.Write("Perimetro de um Retangulo: ");
                return (2 * Base) + (2 * altura);
            }
        }
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo(10, 10);
            Circulo circ = new Circulo(20);
            Triangulo trig = new Triangulo(20, 10, 23);

            Console.WriteLine($"Retângulo - Perímetro: {ret.perimetro()}");
            Console.WriteLine($"Retângulo - Área: {ret.area()}");
            Console.WriteLine("---"); // Separator for better readability

            Console.WriteLine($"Círculo - Perímetro: {circ.perimetro()}");
            Console.WriteLine($"Círculo - Área: {circ.area()}");
            Console.WriteLine("---");

            Console.WriteLine($"Triângulo - Perímetro: {trig.perimetro()}");
            Console.WriteLine($"Triângulo - Área: {trig.area()}");

            Console.ReadKey();
        }
    }
}
