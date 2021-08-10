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
    public class DeleteModel : PageModel
    {
        private readonly Addidas_Outlet.Data.Addidas_OutletContext _context;

        public DeleteModel(Addidas_Outlet.Data.Addidas_OutletContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sub_Category Sub_Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sub_Category = await _context.Sub_Category.FirstOrDefaultAsync(m => m.id == id);

            if (Sub_Category == null)
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

            Sub_Category = await _context.Sub_Category.FindAsync(id);

            if (Sub_Category != null)
            {
                _context.Sub_Category.Remove(Sub_Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
