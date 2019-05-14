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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext _context;

        public DetailsModel(RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext context)
        {
            _context = context;
        }

        public MedProcedure MedProcedure { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MedProcedure = await _context.MedProcedure
                .Include(m => m.Physician).FirstOrDefaultAsync(m => m.MedProcedureID == id);

            if (MedProcedure == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
