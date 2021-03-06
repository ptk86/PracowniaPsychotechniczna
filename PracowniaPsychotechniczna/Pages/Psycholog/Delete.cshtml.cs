﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Pages.Psycholog
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationContext _context;

        public DeleteModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model.Psycholog Psycholog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Psycholog = await _context.Psycholog.SingleOrDefaultAsync(m => m.Id == id);

            if (Psycholog == null)
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

            Psycholog = await _context.Psycholog.FindAsync(id);

            if (Psycholog != null)
            {
                _context.Psycholog.Remove(Psycholog);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
