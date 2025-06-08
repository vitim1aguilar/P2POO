using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Factories
{
    public class PedidoFactory
    {
        public Pedido CriarPedido(Cliente cliente, List<ItemPedido> itens)
        {
            return new Pedido(cliente, itens);
        }
    }
}
