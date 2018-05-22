using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracowniaPsychotechniczna.Dal;

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
                TypyBadan = _context.TypBadania
            };
            return Page();
        }

        [BindProperty]
        public CreateBadanie Badanie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Badanie = new CreateBadanie
                {
                    Psychologowie = _context.Psycholog,
                    TypyBadan = _context.TypBadania
                };
                return Page();
            }

            var badanie = new Model.Badanie
            {
                TypBadaniaId = Badanie.TypBadaniaId,
                PsychologId = Badanie.PsychologId,
                DataBadania = DateTime.Now,
                BadanyId = Badanie.BadanyId,
                FrimaBadanegoId = Badanie.BadanyId
            };

            _context.Badanies.Add(badanie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}