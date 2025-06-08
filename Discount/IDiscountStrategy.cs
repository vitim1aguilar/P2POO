using P2POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2POO.Discount
{
    public interface IDiscountStrategy
    {
        decimal CalcularDesconto(Pedido pedido);
    }
}
