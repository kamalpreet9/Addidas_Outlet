﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Addidas_Outlet.Data;
using Addidas_Outlet.Models;

namespace Addidas_Outlet.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly Addidas_Outlet.Data.Addidas_OutletContext _context;

        public DetailsModel(Addidas_Outlet.Data.Addidas_OutletContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
