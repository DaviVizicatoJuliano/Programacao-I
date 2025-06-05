using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Estacionamento_Portari
{
    internal class Program
    {
        public class Veiculo
        {
            public string placa_veiculo = "";
            public string marca_veiculo = "";
            public string modelo_veiculo = "";
            public int tipo_veiculo = 0;
            public int hora_entrada = -01;
            public int minuto_entrada = 00;
            public int hora_saida;
            public int minuto_saida;

            //variaveis de utilizacao
            public int tempo_total;
            public int contabilizador_tempo;

            public Veiculo()
            {
                Console.Write("Insira a placa do Veiculo: ");
                placa_veiculo = Console.ReadLine();

                Console.Write("Insira a marca do Veiculo: ");
                marca_veiculo = Console.ReadLine();

                Console.Write("Insira o modelo do Veiculo: ");
                modelo_veiculo = Console.ReadLine();

                Console.Write("1. Veiculo de Passeio. \n2. Veiculo Utilitário \n3. Ônibus \n4. Caminhão \n ");
                Console.Write("Insira o tipo do veiculo: ");

                tipo_veiculo = int.Parse(Console.ReadLine());

                Console.Write("Insira a hora de entrada: ");
                hora_entrada = int.Parse(Console.ReadLine());

                Console.Write("Insira o minuto de entrada: ");
                minuto_entrada = int.Parse(Console.ReadLine());
            }

            /*
            public int Calcular_horas()
            {
                
            }
            }
            public Saida_Veiculo()
            {
                Console.Write("Insira a hora de saida do veiculo: ");
                hora_saida = int.Parse(Console.ReadLine());

                Console.Write("Insira o minuto de saida: ");
                minuto_saida = int.Parse(Console.ReadLine());

                tempo_total = (hora_saida * 60) + minuto_saida;


            
            }*/
        }
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[10];

            /*for (int i; i<= 10; i++)
            {
                veiculo[i] = new Veiculo();
            }*/
            int op;
            int contador_veiculo = 0;
            int vaga_carro;

            while (true) {
                Console.WriteLine("1. Cadastrar Carro");
                Console.WriteLine("2. Saida de Carro");
                Console.WriteLine("3. Sair");

                Console.Write("Escolha a opção: ");
                op = int.Parse(Console.ReadLine());
                
                switch(op)
                {
                    case 1:
                        if (contador_veiculo < 10)
                        {
                            Console.WriteLine("Sistema de Cadastro de Veiculo");
                            Console.WriteLine("Qual Vaga deseja ocupar? (0 a 9)");
                            vaga_carro = int.Parse(Console.ReadLine());
                            if (veiculo[vaga_carro] == null) {
                            
                            veiculo[vaga_carro] = new Veiculo();
                            contador_veiculo++;
                            Console.WriteLine("Veiculo Cadastrado com sucesso!"); 
                            }else
                            {
                                Console.WriteLine("Vaga Ocupada");
                            }
    
                        } else
                        {
                            Console.WriteLine("Total de Veiculos Cadastrado!");
                        }
                            break;
                    case 2:
                        Console.WriteLine("Sistema de Saida de Veiculo");
                        for (int i = 0; i < veiculo.Length; i++)
                            {
                                Veiculo v = veiculo[i];
                            if (v != null) {
                                Console.WriteLine("------------------------------");
                                Console.WriteLine($"Vaga: {i}");
                                Console.WriteLine("Modelo do Veiculo: " + v.modelo_veiculo);
                                Console.WriteLine("Tipo do Veiculo: " + v.tipo_veiculo);
                                Console.WriteLine("Hora e Minuto de Entrada: " + v.hora_entrada + ":" + v.minuto_entrada);
                                Console.WriteLine("------------------------------");
                            } else {
                                Console.WriteLine("------------------------------");
                                Console.WriteLine($"Vaga: {i}");
                                Console.WriteLine("Nenhum Veiculo Cadastrado Nessa Vaga");
                                Console.WriteLine("------------------------------");
                            }
                                
                            }
                        
                        break;
                    case 3:
                        Console.WriteLine("Saindo do sistema...");
                        return;
                        
                    default:

                        Console.WriteLine("Opção inválida. Por favor, escolha uma das opções do menu.");
                        break;
                }

            }
        }
    }
}
