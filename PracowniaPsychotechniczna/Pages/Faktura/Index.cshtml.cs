using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Pages.Faktura
{
    public class IndexModel : PageModel
    {
        private readonly PracowniaPsychotechniczna.Dal.ApplicationContext _context;

        public IndexModel(PracowniaPsychotechniczna.Dal.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Faktura> Faktury { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {

            var faktury = await _context.Faktura.Include(f => f.FakturaBadanieList)
                                            .ThenInclude(fb => fb.Badanie.FirmaBadanie.Firma)
                                          .Include(f => f.FakturaBadanieList)
                                            .ThenInclude(fb => fb.Badanie.TypBadania).ToListAsync();
            
            Faktury = faktury.Select(f =>
                                        new Faktura
                                        {
                                            Id = f.Id,
                                            NazwaFirmy = f.FakturaBadanieList.FirstOrDefault().Badanie.FirmaBadanie.Firma.Nazwa,
                                            LiczbaBadan = f.FakturaBadanieList.Count,
                                            CalkowityKosztBadan = f.FakturaBadanieList.Sum(fb => fb.Badanie.TypBadania.Cena)
                                        })
                                    .OrderByDescending(dz => dz.CalkowityKosztBadan).ToList();

            return Page();
        }

    }
}
