using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class Retangulo
    {
        // As formulas matemáticas foram pesquisadas na internet

        public double Altura;
        public double Largura;

        /// <summary>
        /// Calcular Area de um retângulo usando Altura e Largura.
        /// </summary>

        public double Area()
        {

            double area = Altura * Largura;
            return area;

        }

        /// <summary>
        /// Calcular Perimetro de um retângulo usando Altura e Largura.
        /// </summary>
        public double Perimetro()
        {

            double perimetro = (Altura * 2) + (Largura * 2);
            return perimetro;

        }

        /// <summary>
        /// Calcular a Diagonal de um retângulo usando Altura e Largura.
        /// </summary>

        public double Diagonal()
        {

            double diagonal = Math.Sqrt(Largura + Altura);
            return diagonal;

        }

    }
}
