using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Addidas_Outlet.Data;
using Addidas_Outlet.Models;

namespace Addidas_Outlet.Pages.Sub_Categories
{
    public class IndexModel : PageModel
    {
        private readonly Addidas_Outlet.Data.Addidas_OutletContext _context;

        public IndexModel(Addidas_Outlet.Data.Addidas_OutletContext context)
        {
            _context = context;
        }

        public IList<Sub_Category> Sub_Category { get;set; }

        public async Task OnGetAsync()
        {
            Sub_Category = await _context.Sub_Category.ToListAsync();
        }
    }
}
