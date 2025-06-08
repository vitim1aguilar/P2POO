using P2POO.Models;
using P2POO.Repositories;
using P2POO.Services.Logging;
using P2POO.Factories;
using P2POO.Services.Discount;

var logger = new ConsoleLogger();

var produtoRepo = new ProdutoRepository();
var clienteRepo = new ClienteRepository();
var pedidoRepo = new PedidoRepository();
var pedidoFactory = new PedidoFactory();

var descontoCategoria = new CategoriaDiscountStrategy();
var descontoQuantidade = new QuantidadeDiscountStrategy();

// simulando os dados
var cliente = new Cliente("Victor Aguilar", "victor@gmail.com", "40028922");
clienteRepo.Adicionar(cliente);

var notebook = new Produto("Notebook", 4500, "Eletrônico");
var livro = new Produto("Dom Casmurro", 30, "Livro");

produtoRepo.Adicionar(notebook);
produtoRepo.Adicionar(livro);

var itens = new List<ItemPedido>
{
    new ItemPedido(notebook, 1),
    new ItemPedido(livro, 1)
};

var pedido = pedidoFactory.CriarPedido(cliente, itens);
pedidoRepo.Adicionar(pedido);

logger.Log("Pedido criado com sucesso");

// calcular desconto
var descontoTotal = descontoCategoria.CalcularDesconto(pedido) +
                    descontoQuantidade.CalcularDesconto(pedido);

Console.WriteLine("===== Relatório de Pedidos =====");
foreach (var p in pedidoRepo.ObterTodos())
{
    Console.WriteLine($"\nPedido: {p.Id}");
    Console.WriteLine($"Cliente: {p.Cliente.Nome}");
    Console.WriteLine($"Data: {p.Data}");

    foreach (var item in p.Itens)
    {
        Console.WriteLine($" - {item.Produto.Nome} x{item.Quantidade} - R$ {item.ValorTotal}");
    }

    Console.WriteLine($"Subtotal: R$ {p.ValorTotal}");
    Console.WriteLine($"Desconto aplicado: R$ {descontoTotal}");
    Console.WriteLine($"Total Fonal: R$ {p.ValorTotal - descontoTotal}");
}

logger.Log("Relatório gerado.");