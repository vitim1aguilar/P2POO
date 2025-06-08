using P2POO.Interfaces;
using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> _produtos = new();

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> ObterTodos() => _produtos;

        public Produto? ObterPorId(Guid id) =>
            _produtos.FirstOrDefault(p => p.Id == id);
    }
}
