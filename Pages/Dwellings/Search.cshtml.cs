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
    public class SearchModel : PageModel
    {
        private readonly RealEstatePMP.Data.RealEstatePMPContext _context;

        public SearchModel(RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _context = context;
        }

        public IList<Dwelling> Dwelling { get;set; }

        public bool SearchCompleted { get; set; }

        public string Query { get; set; }

        public async Task OnGetAsync(string query)
        {
            Query = query;
            if(!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Dwelling = await _context.Dwelling
                .Where(d => d.CityName.StartsWith(query))
                .ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                Dwelling = new List<Dwelling>();
            }
            
        }
    }
}
