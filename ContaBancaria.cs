using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class ContaBancaria
    {
        private string _nome;
        public int NumeroConta { get; private set; }
        public double DepositoInicial { get; private set; }

        ContaBancaria(string nome, int numeroConta, double depositoInicial)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            DepositoInicial = depositoInicial;

        }
        ContaBancaria(string nome, int numeroConta)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            DepositoInicial = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


    }
}
