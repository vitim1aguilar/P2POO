using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Models
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Categoria { get; private set; }

        public Produto(string nome, decimal preco, string categoria)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("");

            if (preco <= 0)
                throw new ArgumentException("");

            if (string.IsNullOrWhiteSpace(categoria))
                throw new ArgumentException("");

            Id = Guid.NewGuid();
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}
