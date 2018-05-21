using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.Psycholog
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
        public Model.Psycholog Psycholog { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Psycholog.Add(Psycholog);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}