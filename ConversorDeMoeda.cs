using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class ConversorDeMoeda
    {

        public static double Cotacao;
        public static double ValorCompra;
        public static int Iof = 6;
        public static double ConversaoDolar(double compra)
        {
            double p = Iof / 100;
            double valorIof = ValorCompra * p;
            return compra = (ValorCompra * Cotacao) + valorIof;             
        }

    }
}
