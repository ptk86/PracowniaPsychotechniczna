using System;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Pages.Badanie
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationContext _context;

        public CreateModel(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Badanie = new CreateBadanie
            {
                Psychologowie = _context.Psycholog,
                TypyBadan = _context.TypBadania,
                FirmaId = 0
            };
            return Page();
        }

        [BindProperty]
        public CreateBadanie Badanie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Badanie.Psychologowie = _context.Psycholog;
                Badanie.TypyBadan = _context.TypBadania;
                return Page();
            }

            var badanie = new Model.Badanie
            {
                TypBadaniaId = Badanie.TypBadaniaId,
                PsychologId = Badanie.PsychologId,
                DataBadania = DateTime.Now,
                BadanyId = Badanie.BadanyId
             };

            if (!Badanie.CzyPlatnoscWlasna)
            {
                badanie.FirmaBadanie = new FirmaBadanie() { FirmaId = Badanie.FirmaId };
            }

            _context.Badanies.Add(badanie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}