using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Aula4
{
    internal class CadastroFuncionario
    {
        private Funcionario[] funcionario = new Funcionario[10];
        private int contador = 0;

        public void Cadastrar(string nome, string cargo, int salario)
        {
            if (contador < funcionario.Length)
            {
                funcionario[contador] = new Funcionario(nome, cargo, salario);
                contador++;
            }
            else
            {
                Console.WriteLine("Limite Atingido");
            }
        }

        public void Listar()
        {
            for (int i = 0; i < funcionario.Length; i++)
            {
                if (funcionario[i] != null)
                {
                    if (funcionario[i].salario > 3000)
                    {
                        funcionario[i].Exibir();
                    }
                }
            }
        }

    }
}
