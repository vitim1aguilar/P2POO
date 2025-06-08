using P2POO.Interfaces;
using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly List<Cliente> _clientes = new();

        public void Adicionar(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public IEnumerable<Cliente> ObterTodos() => _clientes;

        public Cliente? ObterPorId(Guid id) =>
            _clientes.FirstOrDefault(c => c.Id == id);
    }
}
