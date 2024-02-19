using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD1.Data;
using CRUD1.Model;

namespace CRUD1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CRUD1.Data.CRUD1Context _context;

        public IndexModel(CRUD1.Data.CRUD1Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
