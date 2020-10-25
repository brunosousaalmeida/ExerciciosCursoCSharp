using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class Funcionario1
    {
        public string _nome;
        public double Salario { get; private set; }
        public int Id { get; set; }

        

        public Funcionario1(int id, string nome,  double salario)
        {
            Id = id;
            Nome = nome;            
            Salario = salario;
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

        public double AumentarSalario(double aliquotaAumento)
        {
            return Salario += (aliquotaAumento / 100) * Salario;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Nome: {_nome} - Salario: R${Salario:F2} ";
        }
    }
}
