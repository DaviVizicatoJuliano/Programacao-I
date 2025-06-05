using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicios_Sergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercicio 1
            string name;
            int age;

            Console.Write("Insira seu nome: ");
            name = Console.ReadLine();
            Console.Write("Insira sua idade: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá " + name + " Você tem " + age);
            */

            /*
            //Exercicio 2
            int num1;
            int num2;
            int soma;

            Console.Write("Insira o primeiro Numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo Numero: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2; 

            Console.WriteLine("Soma dos numeros: " + soma);
            Console.ReadKey();
            */

            /*
            //Exercicio 3
            int num;
            int resto;

            Console.Write("Insira o Numero: ");
            num = int.Parse(Console.ReadLine());
            resto = num % 2;

            if (resto == 0)
            {
                Console.WriteLine("Numero Par!");
            }
            else
            {
                Console.WriteLine("Numero Impar");
            }
            */

            /*
            //Exercicio 4 
            int op;

            Console.WriteLine("Opção 1 : Cadastrar ");
            Console.WriteLine("Opção 2: Exibir Dados");
            Console.WriteLine("Opção 3: Sair");
            Console.Write("Escolha Uma Opção: ");
            

            try{
            
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Cadastro");
                        break;

                    case 2:
                        Console.WriteLine("Exibir Dados");
                        break;

                    case 3:
                        Console.WriteLine("Saindo");
                        break;
                }
            }
            catch (Exception e){
                Console.WriteLine("Opção Inválida, Tente Novamente");
            }   
            */

            /*
            //Exercicio 5
            int num = 5;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} --> " + num * i);
            }
            */

            //Challenge

            for (int i = 1; i <= 3; i++)
            {
                int senha;
                Console.Write("Insira a senha: ");
                senha  = int.Parse(Console.ReadLine());

                if (senha == 1234)
                {
                    Console.WriteLine("Senha Correta!");
                    break;
                } else
                {
                    Console.WriteLine("Senha Incorreta, tente novamente");
                }
            }
        }

    }
}
