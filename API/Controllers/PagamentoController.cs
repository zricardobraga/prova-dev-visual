using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Linq;

namespace API.Controllers
{

    [ApiController]
    [Route("api/pagamento")]
    public class PagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public PagamentoController(DataContext context)
        {
            _context = context;
        }

        //GET: api/pagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            return Ok(_context.Pagamentos.ToList());
        }

        //POST: api/pagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Pagamento pagamento)
        {
           _context.Pagamentos.Add(pagamento);
           _context.SaveChanges();
           return Created("", pagamento);
        }
    }
}