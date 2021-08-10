﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Addidas_Outlet.Data;
using Addidas_Outlet.Models;

namespace Addidas_Outlet.Pages.Sub_Categories
{
    public class CreateModel : PageModel
    {
        private readonly Addidas_Outlet.Data.Addidas_OutletContext _context;

        public CreateModel(Addidas_Outlet.Data.Addidas_OutletContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sub_Category Sub_Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sub_Category.Add(Sub_Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
