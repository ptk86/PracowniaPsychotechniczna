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
    public class IndexModel : PageModel
    {
        private readonly PracowniaPsychotechniczna.Dal.ApplicationContext _context;

        public IndexModel(PracowniaPsychotechniczna.Dal.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Model.Badany> Badany { get;set; }

        public async Task OnGetAsync()
        {
            Badany = await _context.Badany.ToListAsync();
        }
    }
}
