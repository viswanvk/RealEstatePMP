﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstatePMP.Data;
using RealEstatePMP.Models;

namespace RealEstatePMP.Pages.SalesOffices
{
    public class CreateModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public CreateModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SalesOffice SalesOffice { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SalesOffice.Add(SalesOffice);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
