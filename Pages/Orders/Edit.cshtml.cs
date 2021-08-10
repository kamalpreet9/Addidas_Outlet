using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Addidas_Outlet.Data;
using Addidas_Outlet.Models;

namespace Addidas_Outlet.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly Addidas_Outlet.Data.Addidas_OutletContext _context;

        public EditModel(Addidas_Outlet.Data.Addidas_OutletContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Categories)
                .Include(o => o.Product)
                .Include(o => o.Sub_Category).FirstOrDefaultAsync(m => m.id == id);

            if (Order == null)
            {
                return NotFound();
            }
           ViewData["CategoriesID"] = new SelectList(_context.Categories, "id", "Category_Name");
           ViewData["ProductID"] = new SelectList(_context.Product, "id", "Product_Name");
           ViewData["Sub_CategoryID"] = new SelectList(_context.Set<Sub_Category>(), "id", "Sub_Categories");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.id == id);
        }
    }
}
