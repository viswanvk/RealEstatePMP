using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePMP.Data;
using RealEstatePMP.Models;

namespace RealEstatePMP.Pages.Dwellings
{
    public class IndexModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public IndexModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        public IList<Dwelling> Dwelling { get;set; }

        public async Task OnGetAsync()
        {
            Dwelling = await _context.Dwelling
                .Include(d => d.Agent)
                .Include(d => d.City).ToListAsync();
        }
    }
}
