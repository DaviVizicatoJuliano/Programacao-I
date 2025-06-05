using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Revisao
{
    internal class Turma
    {
        Aluno[] aluno = new Aluno[3];
        private int contador = 0;
        public void Cadastrar(string nome, double nota)
        {
            if(contador < aluno.Length)
            {
                aluno[contador] = new Aluno(nome,nota);
                contador++;
            }
        }

        public void Listar()
        {
            for(int i = 0; i < aluno.Length; i++)
            {
                if(aluno != null)aluno[i].Exibir();
            }
        }
    }
}
