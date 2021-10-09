using System;
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
    public class IndexModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public IndexModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        public int TotalOffices { get; set; }
        public IList<SalesOffice> SalesOffice { get;set; }
        
        public async Task OnGetAsync()
        {
            SalesOffice = await _context.SalesOffice.ToListAsync();
            TotalOffices = await _context.SalesOffice.CountAsync();
        }
    }
}
