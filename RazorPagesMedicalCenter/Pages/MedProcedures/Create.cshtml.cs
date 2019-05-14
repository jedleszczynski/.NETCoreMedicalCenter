using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Pages.MedProcedures
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext _context;

        public CreateModel(RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PhysicianID"] = new SelectList(_context.Physician, "PhysicianID", "PhysicianID");
            return Page();
        }

        [BindProperty]
        public MedProcedure MedProcedure { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MedProcedure.Add(MedProcedure);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}