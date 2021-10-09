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

namespace RealEstatePMP.Pages.Agents
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
        ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "SalesOfficeId", "Name");
            return Page();
        }

        [BindProperty]
        public Agent Agent { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Phone Number Validation
            var PhoneNum = Agent.PhoneNumber;
            bool PhoneNumAlreadyExists = await _context.Agent.AnyAsync (x =>x.PhoneNumber == PhoneNum);

            if (PhoneNumAlreadyExists)
            {
                ModelState.AddModelError("Agent.PhoneNumber", "Agent with this phone number already exists");
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Agent.Add(Agent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
