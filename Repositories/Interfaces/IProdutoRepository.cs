using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Interfaces
{
    interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        IEnumerable<Produto> ObterTodos();
        Produto? ObterPorId(Guid id);
    }
}

