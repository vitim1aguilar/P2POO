using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Interfaces
{
    public interface IPedidoRepository
    {
        void Adicionar(Pedido pedido);
        IEnumerable<Pedido> ObterTodos();
    }
}
