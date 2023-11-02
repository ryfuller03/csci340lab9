using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WalterUniversity.Models;
using WalterUniversity.Data;

namespace WalterUniversity.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly WalterUniversity.Data.SchoolContext _context;

        public IndexModel(WalterUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Instructor> Instructor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Instructors != null)
            {
                Instructor = await _context.Instructors.ToListAsync();
            }
        }
    }
}
