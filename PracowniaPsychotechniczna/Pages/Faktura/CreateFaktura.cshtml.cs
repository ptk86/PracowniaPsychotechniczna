using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Pages.Faktura
{
    public class CreateFakturaModel : PageModel
    {
        private readonly PracowniaPsychotechniczna.Dal.ApplicationContext _context;

        public CreateFakturaModel(PracowniaPsychotechniczna.Dal.ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            var firma = await _context.Firma.Include(f => f.FirmaBadanieList)
                                        .ThenInclude(fb => fb.Badanie.Badany)
                                      .Include(f => f.FirmaBadanieList)
                                        .ThenInclude(fb => fb.Badanie.TypBadania)
                                      .Include(f => f.FirmaBadanieList)
                                        .ThenInclude(fb => fb.Badanie.FakturaBadanie)
                                      .FirstOrDefaultAsync(f => f.Id == id);
            if (firma == null)
            {
                return NotFound();
            }

            CreateFaktura = new CreateFaktura
            {
                Sprzedawca = new Firma
                {
                    Nazwa = "CBMP Piotr Kiliński",
                    Adres = "ul. Irzykowskiego 3/24, 42-207 Częstochowa",
                    Nip = "9492000541"
                },
                Nabywca = new Firma
                {
                    Id = firma.Id,
                    Nazwa = firma.Nazwa,
                    Adres = firma.Adres,
                    Nip = firma.Nip
                },
                Badania = firma.FirmaBadanieList.Where(fb => fb.Badanie.FakturaBadanie == null).Select(fb => new Badanie
                {
                    Id = fb.BadanieId,
                    Imie = fb.Badanie.Badany.Imie,
                    Nazwisko = fb.Badanie.Badany.Nazwisko,
                    Typ = fb.Badanie.TypBadania.Nazwa,
                    Cena = fb.Badanie.TypBadania.Cena,
                }).OrderByDescending(b => b.Cena).ToList()
        };

            return Page();
        }

        [BindProperty]
        public CreateFaktura CreateFaktura { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var firma = await _context.Firma.Where(f => f.Id == id).FirstOrDefaultAsync();

            var badaniaDoZafakturowania = await _context.Badanie
                .Where(b => b.FakturaBadanie == null && b.FirmaBadanie.FirmaId == id).ToListAsync();

            var nowaFaktura = new Model.Faktura
            {
                Data = DateTime.Now,
                FakturaBadanieList = badaniaDoZafakturowania.Select(b => new FakturaBadanie
                {
                    Badanie = b
                }).ToList()
            };

            _context.Faktura.Add(nowaFaktura);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Oczekujace");
        }

    }
}