using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Models
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<ItemPedido> Itens { get; private set; }
        public DateTime Data { get; private set; }
        public decimal ValorTotal => Itens.Sum(i => i.ValorTotal);

        public Pedido(Cliente cliente, List<ItemPedido> itens)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            if (itens == null || !itens.Any())
                throw new ArgumentException("O pedido deve ter pelo menos um item.");

            Id = Guid.NewGuid();
            Cliente = cliente;
            Itens = itens;
            Data = DateTime.Now;
        }
    }
}
