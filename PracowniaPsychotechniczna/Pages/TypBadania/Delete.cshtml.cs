using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.TypBadania
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationContext _context;

        public DeleteModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model.TypBadania TypBadania { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypBadania = await _context.TypBadania.SingleOrDefaultAsync(m => m.Id == id);

            if (TypBadania == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypBadania = await _context.TypBadania.FindAsync(id);

            if (TypBadania != null)
            {
                _context.TypBadania.Remove(TypBadania);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
