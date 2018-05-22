using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Controller
{
    [Produces("application/json")]
    [Route("api/autocomplete")]
    public class AutocompleteController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ApplicationContext _context;

        public AutocompleteController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("badani")]
        public IActionResult GetBadani(string searchTerm)
        {
            var filtered = _context.Badany
                                .Where(b => b.Pesel.StartsWith(searchTerm) ||
                                            b.Imie.StartsWith(searchTerm) ||
                                            b.Nazwisko.StartsWith(searchTerm) );

            return Ok(filtered);
        }

        [HttpGet("firmy")]
        public IActionResult GetFirmy(string searchTerm)
        {
            return Ok(_context.Firma
                .Where(f => f.Nazwa.StartsWith(searchTerm) ||
                            f.Nip.StartsWith(searchTerm)));
        }
    }
}