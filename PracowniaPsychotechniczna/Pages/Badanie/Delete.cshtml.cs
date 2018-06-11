using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.Badanie
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationContext _context;

        public DeleteModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BadanieIndexListItem Badanie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var badanieDb = await _context.Badanie
                                          .Include(b => b.FirmaBadanie.Firma)
                                          .Include(b => b.TypBadania)
                                          .Include(b => b.Badany)
                                          .SingleOrDefaultAsync(m => m.Id == id);


            Badanie = CreateFrom(badanieDb);

            if (Badanie == null)
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

            var badanieDb = await _context.Badanie.SingleOrDefaultAsync(m => m.Id == id);

            Badanie = CreateFrom(badanieDb);

            if (Badanie != null)
            {
                _context.Badanie.Remove(badanieDb);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        private BadanieIndexListItem CreateFrom(Model.Badanie badanieDb)
        {
            return new BadanieIndexListItem
            {
                Id = badanieDb.Id,
                Frima = badanieDb.FirmaBadanie?.Firma?.Nazwa,
                TypBadania = badanieDb.TypBadania.Nazwa,
                Nazwisko = badanieDb.Badany.Nazwisko,
                Imie = badanieDb.Badany.Imie,
                DataBadania = badanieDb.DataBadania
            };
        }

    }
}
