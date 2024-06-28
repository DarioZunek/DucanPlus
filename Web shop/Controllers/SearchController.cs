using Microsoft.AspNetCore.Mvc;

namespace Web_shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : Controller
    {
        private readonly DucanPlusDbContext _context;

        public SearchController(DucanPlusDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string term)
        {
            var results = _context.Products!
                                  .Where(p => p.Name.Contains(term))
                                  .Select(p => new { p.Name, p.CategoryId })
                                  .ToList();

            return Ok(results);
        }
    }
}
