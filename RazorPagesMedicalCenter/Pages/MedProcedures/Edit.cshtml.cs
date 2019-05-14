using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Pages.MedProcedures
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext _context;

        public EditModel(RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["PhysicianID"] = new SelectList(_context.Physician, "PhysicianID", "PhysicianID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MedProcedure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedProcedureExists(MedProcedure.MedProcedureID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MedProcedureExists(int id)
        {
            return _context.MedProcedure.Any(e => e.MedProcedureID == id);
        }
    }
}
