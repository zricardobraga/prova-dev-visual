using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendaController : ControllerBase
    {
        private readonly DataContext _context;
        public VendaController(DataContext context)
        {
            _context = context;
        }

        //GET: api/venda/list
        //ALTERAR O MÉTODO PARA MOSTRAR TODOS OS DADOS DA VENDA E OS DADOS RELACIONADOS
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            return Ok(_context.Vendas
            .Include(v => v.Itens)
            .ThenInclude(i => i.Produto.Categoria)
            .ToList());
        }

        //Get: api/venda/create
        [HttpGet]
        [Route("create/{cliente}/{carrinhoId}/{formaPagamentoId}")]
        public IActionResult Create([FromRoute] string cliente, string carrinhoId, int formaPagamentoId)
        {
            Venda venda = new ();
            venda.Cliente = cliente;
            venda.IdPagamento = formaPagamentoId;
            venda.Itens = _context.ItensVenda.Where(i => i.CarrinhoId == carrinhoId).ToList();
            _context.Vendas.Add(venda);
            _context.ItensVenda.UpdateRange(venda.Itens);
            _context.SaveChanges();
            return Created("", venda);

        }
    }
}