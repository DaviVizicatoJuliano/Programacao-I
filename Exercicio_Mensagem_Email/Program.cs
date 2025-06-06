using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Mensagem_Email
{
    internal class Program
    {
        class Mensagem
        {
            public virtual void Enviar()
            {
                Console.WriteLine("Mensagem Genérica Enviada");
            }
        }

        class MensagemTexto : Mensagem
        {
            private int numero;
            private string conteudo;

            public MensagemTexto(int numero, string conteudo)
            {
                this.numero = numero;
                this.conteudo = conteudo;
            }

            public override void Enviar()
            {
                Console.WriteLine($"Mensagem de texto Genérica");
            }

            public void Enviar(int numero, string conteudo) 
            { 
                Console.WriteLine($"Mensagem de texto enviada para {numero}: {conteudo}");
            }
        }

        class MensagemEmail : Mensagem 
        {
            private string email;
            private string conteudo;

            public MensagemEmail (string email, string conteudo)
            {
                this.email = email;
                this.conteudo= conteudo;
            }

            public override void Enviar() {
                Console.WriteLine("Mensagem de Email Generica");
            }

            public void Enviar(string email, string conteudo) 
            {
                Console.WriteLine($"Email enviado para {email}: {conteudo}");
            }
        }
        static void Main(string[] args)
        {
            int op;

            while (true) {

                Console.Write("1.Enviar Mensagem de Texto \n 2.Enviar Mensagem de Email \n 3.Sair \n Insira sua opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 1:
                        Console.Write("Insira o numero do telefone: ");
                        int telefone = int.Parse(Console.ReadLine());
                        Console.Write("Insira o conteudo: ");
                        string conteudo = Console.ReadLine();
                        MensagemTexto mensagem = new MensagemTexto(telefone,conteudo);
                        mensagem.Enviar(telefone, conteudo);
                        break;

                    case 2:
                        Console.Write("Insira o email: ");
                        string email = Console.ReadLine();
                        Console.Write("Insira o conteudo: ");
                        string conteudo_email = Console.ReadLine();
                        MensagemEmail mensagememail = new MensagemEmail(email, conteudo_email);
                        mensagememail.Enviar(email, conteudo_email);
                        break;

                    case 3:
                        return;
                }
            }
        }
    }
}
