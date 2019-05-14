using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Pages.MedProcedures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext _context;

        public IndexModel(RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext context)
        {
            _context = context;
        }

        public IList<MedProcedure> MedProcedure { get;set; }

        public async Task OnGetAsync()
        {
            MedProcedure = await _context.MedProcedure
                .Include(m => m.Physician).ToListAsync();
        }
    }
}
