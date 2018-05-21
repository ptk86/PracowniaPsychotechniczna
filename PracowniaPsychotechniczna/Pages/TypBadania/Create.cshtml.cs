using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.TypBadania
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
            return Page();
        }

        [BindProperty]
        public Model.TypBadania TypBadania { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TypBadania.Add(TypBadania);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}