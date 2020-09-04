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

            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;

        }

        /// <summary>
        /// Retornar em forma de string os dados coletados e calculados
        /// </summary>
        /// <returns>dadosString</returns>
        public override string ToString()
        {
            return $"O valores de largura e altura são: {Largura} e {Altura} (respectivamente)\r\n" +
                $"Os dados para esse retangulo são:\r\n" +
                $"Area: {Area():F2}\r\n" +
                $"Perimetro: {Perimetro():F2}\r\n" +
                $"Diagonal: {Diagonal():F2}\r\n";
        }

    }
}
