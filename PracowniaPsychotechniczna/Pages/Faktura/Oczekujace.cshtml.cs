using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.Faktura
{
    public class OczekujaceModel : PageModel
    {
        private readonly ApplicationContext _context;

        public OczekujaceModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<OczekujacaFaktura> OczekujaceDoZafakturowania { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            var doZafakturowania = await _context.Badanie
                .Where(b => b.FakturaBadanie == null)
                .Where(b => b.FirmaBadanie != null)
                .Include(b => b.TypBadania)
                .GroupBy(b => b.FirmaBadanie.Firma)
                .ToListAsync();


            OczekujaceDoZafakturowania = doZafakturowania
                .Select(gr =>
                    new OczekujacaFaktura
                    {
                        Id = gr.Key.Id,
                        NazwaFirmy = gr.Key.Nazwa,
                        LiczbaBadan = gr.Count(),
                        CalkowityKosztBadan = gr.Sum(b => b.TypBadania.Cena)
                    })
                .OrderByDescending(dz => dz.CalkowityKosztBadan).ToList();

            return Page();
        }
    }
}