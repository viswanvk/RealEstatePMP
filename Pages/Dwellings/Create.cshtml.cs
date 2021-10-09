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
    public class CreateModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public CreateModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AgentId"] = new SelectList(_context.Agent, "AgentId", "FullName");
        ViewData["CityId"] = new SelectList(_context.City, "CityId", "Name");
            return Page();
        }

        [BindProperty]
        public Dwelling Dwelling { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            //// DATE VALIDATION
            //DateTime AvailabilyDate = Dwelling.AvailableDate.Date;
            //DateTime latestAllowedYear = DateTime.Now.Date;
            //if (AvailabilyDate <= latestAllowedYear)
            //{
            //    ModelState.AddModelError("Dwelling.AvailableDate", "Please check availability date");
            //}

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            
            _context.Dwelling.Add(Dwelling);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
