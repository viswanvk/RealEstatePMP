﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePMP.Data;
using RealEstatePMP.Models;

namespace RealEstatePMP.Pages.SalesOffices
{
    public class DeleteModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public DeleteModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SalesOffice SalesOffice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SalesOffice = await _context.SalesOffice.FirstOrDefaultAsync(m => m.SalesOfficeId == id);

            if (SalesOffice == null)
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

            SalesOffice = await _context.SalesOffice.FindAsync(id);

            if (SalesOffice != null)
            {
                _context.SalesOffice.Remove(SalesOffice);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
