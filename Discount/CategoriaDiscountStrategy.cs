using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Discount
{
    public class CategoriaDiscountStrategy : IDiscountStrategy
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            var desconto = 0m;

            foreach (var item in pedido.Itens)
            {
                if (item.Produto.Categoria.Equals("Eletrônico", StringComparison.OrdinalIgnoreCase))
                {
                    desconto += item.ValorTotal * 0.10m;
                }
            }

            return desconto;
        }
    }
}
