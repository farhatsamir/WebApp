using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalPojects.Data;
using FinalPojects.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalPojects.Pages.Admin.Medicines
{
    public class IndexModel : PageModel
    {
        private readonly FinalPojects.Data.ApplicationDbContext _context;

        public IndexModel(FinalPojects.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? TradName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MedicineTradeName { get; set; }
        public async Task OnGetAsync()
        {
            var Medicines = from m in _context.Medicine
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Medicines = Medicines.Where(s => s.TradName.Contains(SearchString));
            }

            Medicine = await Medicines.ToListAsync();  
        }
    }
}
