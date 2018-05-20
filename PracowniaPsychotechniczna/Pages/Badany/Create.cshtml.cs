using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Pages.Badany
{
    public class CreateModel : PageModel
    {
        private readonly PracowniaPsychotechniczna.Dal.ApplicationContext _context;

        public CreateModel(PracowniaPsychotechniczna.Dal.ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Model.Badany Badany { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Badany.Add(Badany);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}