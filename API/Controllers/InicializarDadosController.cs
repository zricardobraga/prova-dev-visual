using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 1, Nome = "Produtos importados" },
                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "Vinho", Descricao = "Vinho muito bom", Preco = 78, Quantidade = 50, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Queijo", Descricao = "Queijo muito bom", Preco = 64, Quantidade = 22, CategoriaId = 1 },
                    new Produto { ProdutoId = 3, Nome = "Baguete", Descricao = "Baguete muito boa", Preco = 7, Quantidade = 33, CategoriaId = 1 },
                }
            );

            _context.Pagamentos.AddRange(new Pagamento[]
                {
                    new Pagamento { Id = 1, Nome = "Itaucard", FormaPgto= FormaDePagamento.Cartao},
                    new Pagamento { Id = 2, Nome = "Carnê das Casas Bahia", FormaPgto= FormaDePagamento.Boleto},
                }
            );

            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}