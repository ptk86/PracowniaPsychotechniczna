using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.Badanie
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public IList<BadanieIndexListItem> Badania { get;set; }

        public async Task OnGetAsync()
        {
            var badania = await _context.Badanies
                                            .Include(b => b.Badany)
                                            .Include(b => b.Psycholog)
                                            .Include(b => b.TypBadania)
                                            .Include(b => b.FirmaBadanie)
                                                .ThenInclude(fb => fb.Firma)
                                            .ToListAsync();

            Badania = badania.Select(b => new BadanieIndexListItem
            {
                Id = b.Id,
                Frima = b.FirmaBadanie?.Firma?.Nazwa,
                TypBadania = b.TypBadania.Nazwa,
                Nazwisko = b.Badany.Nazwisko,
                Imie = b.Badany.Imie,
                DataBadania = b.DataBadania
            }).ToList();
        }
    }
}
