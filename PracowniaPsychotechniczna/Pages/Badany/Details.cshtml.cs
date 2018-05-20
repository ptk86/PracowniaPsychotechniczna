using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Pages.Badany
{
    public class DetailsModel : PageModel
    {
        private readonly PracowniaPsychotechniczna.Dal.ApplicationContext _context;

        public DetailsModel(PracowniaPsychotechniczna.Dal.ApplicationContext context)
        {
            _context = context;
        }

        public Model.Badany Badany { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Badany = await _context.Badany.SingleOrDefaultAsync(m => m.Id == id);

            if (Badany == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
