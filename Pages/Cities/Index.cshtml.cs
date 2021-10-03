using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePMP.Data;
using RealEstatePMP.Models;

namespace RealEstatePMP.Pages.Cities
{
    public class IndexModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public IndexModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; }

        public async Task OnGetAsync()
        {
            City = await _context.City.ToListAsync();
        }
    }
}
