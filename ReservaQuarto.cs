using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCursoCSharp
{
    class ReservaQuarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public ReservaQuarto()
        {

        }

        public ReservaQuarto(string nome, string email, int numeroQuarto)
        {
            Nome = nome;
            Email = email;
            NumeroQuarto = numeroQuarto;

        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Email: {Email} - Número do Quarto: {NumeroQuarto}";
        }

    }
}
