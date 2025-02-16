using estudoAPI.Data;
using estudoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace estudoAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class ProdutoController : ControllerBase
        {
            private readonly AppDbContext _context;

            public ProdutoController(AppDbContext context)
            {
                _context = context;
            }

            [HttpPost]
            public async Task<IActionResult> CriarProduto([FromBody] Produto produto)
            {
                if (produto == null)
                {
                    return BadRequest("Dados inválidos.");
                }

                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(CriarProduto), new { id = produto.Id }, produto);
            }
        }
}
