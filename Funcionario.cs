using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        /// <summary>
        /// Calcular Salário Lisquído
        /// </summary>
        /// <returns>salarioLiquido</returns>
        public double SalarioLiquido()
        {
            double valorImposto = (Imposto / 100) * SalarioBruto;
            double salarioLiquido = SalarioBruto - valorImposto;
            return salarioLiquido;
        }

        /// <summary>
        /// Aumentar Salario Bruno
        /// </summary>
        /// <param name="porcent"></param>
        public void AumentarSalario(double porcent)
        {            
            double aumentarSalario = SalarioBruto + (SalarioBruto * porcent/100);
        }

        /// <summary>
        /// Retorna os dados da classe em string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"O valor do imposto é: {Imposto}\b\n" +
                $"O valor do salário liquído é: {SalarioLiquido():F2}";
        }

    }
}
