using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Models
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public Cliente(string nome, string email, string cpf)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("");

            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentException("");

            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
    }
}
