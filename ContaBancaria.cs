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
        public double SaldoConta { get; private set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(string nome, int numeroConta, double depositoInicial)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            DepositoConta(depositoInicial);

        }
        public ContaBancaria(string nome, int numeroConta)
        {
            _nome = nome;
            NumeroConta = numeroConta;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void DepositoConta(double valorDeposito)
        {
            SaldoConta += valorDeposito;
        }

        public void SaqueConta(double valorSaque)
        {
            double valorComTaxa = valorSaque + 5;
            SaldoConta -= valorComTaxa;
        }

        public void AlterarNome(string nomeAtual)
        {
            Nome = nomeAtual;
        }

        public override string ToString()
        {
            return $"O número da conta é {NumeroConta}, o nome do títular é {_nome} e o saldo atual é R${SaldoConta}";
        }

    }
}
