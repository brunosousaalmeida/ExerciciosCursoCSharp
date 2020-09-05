using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ExerciciosCursoCSharp
{

    /// <summary>
    /// Classe Aluno
    /// </summary>
    
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        /// <summary>
        /// Calculo da pontuação final do aluno.
        /// </summary>
        /// <returns></returns>
        public double PontuacaoTotal()
        {
            double pontuacao = Nota1 + Nota2 + Nota3;
            return pontuacao;

        }

        /// <summary>
        /// Retorno dos dados do aluno em string.
        /// </summary>
        /// <returns>dadosAluno</returns>
        public override string ToString()
        {
            if (PontuacaoTotal() >= 60)
            {
                return $"O aluno {Nome} teve um total de {PontuacaoTotal()} e foi aprovado!";
            }
            else
            {
                double dif = 60 - PontuacaoTotal();
                return $"O aluno {Nome} teve um total de {PontuacaoTotal()} e foi reprovado por {dif} pontos.";

            }


        }

    }
}
