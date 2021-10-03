using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstatePMP.Data;
using RealEstatePMP.Models;

namespace RealEstatePMP.Pages.Dwellings
{
    public class EditModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public EditModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dwelling Dwelling { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dwelling = await _context.Dwelling
                .Include(d => d.Agent)
                .Include(d => d.City).FirstOrDefaultAsync(m => m.DwellingId == id);

            if (Dwelling == null)
            {
                return NotFound();
            }
           ViewData["AgentId"] = new SelectList(_context.Agent, "AgentId", "AgentId");
           ViewData["CityId"] = new SelectList(_context.City, "CityId", "CityId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dwelling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DwellingExists(Dwelling.DwellingId))
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

        private bool DwellingExists(int id)
        {
            return _context.Dwelling.Any(e => e.DwellingId == id);
        }
    }
}
