using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class ConversorDeMoeda
    {

        /// <summary>
        /// Conversão real em dolar com 6% de IOF
        /// </summary>
 
        public static int Iof = 6;

        public static double ConversaoDolar(double cotacao, double valorCompra)
        {
           
            double total = valorCompra + (valorCompra * (Iof / 100.0));
            return total *= cotacao;
        }
       

    }
}
