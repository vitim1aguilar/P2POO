using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Discount
{
    public class QuantidadeDiscountStrategy : IDiscountStrategy
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            var desconto = 0m;

            foreach (var item in pedido.Itens)
            {
                if (item.Quantidade >= 5)
                {
                    desconto += item.ValorTotal * 0.05m;
                }
            }

            return desconto;
        }
    }
}
