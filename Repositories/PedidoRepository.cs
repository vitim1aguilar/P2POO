using P2POO.Interfaces;
using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly List<Pedido> _pedidos = new();

        public void Adicionar(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public IEnumerable<Pedido> ObterTodos() => _pedidos;
    }
}
