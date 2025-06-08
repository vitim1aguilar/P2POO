using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Interfaces
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        IEnumerable<Cliente> ObterTodos();
        Cliente? ObterPorId(Guid id);
    }
}

