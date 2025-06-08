using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Models
{
    public class ItemPedido
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

        public decimal ValorTotal => Produto.Preco * Quantidade;

        public ItemPedido(Produto produto, int quantidade)
        {
            if (quantidade <= 0)
                throw new ArgumentException("");

            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
            Quantidade = quantidade;
        }
    }
}
