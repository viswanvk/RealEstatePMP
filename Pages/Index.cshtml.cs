using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstatePMP.Data;

namespace RealEstatePMP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RealEstatePMPContext _context;

        public IndexModel(ILogger<IndexModel> logger, RealEstatePMP.Data.RealEstatePMPContext context)
        {
            _logger = logger;
            _context = context;
        }


        public void OnGet()
        {

        }

        public int TotalAgents { get; set; }
        public async Task OnGetAsync()
        {
            TotalAgents = await _context.Agent.CountAsync();
        }
    }
}
