using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Pages.Patients
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext _context;

        public IndexModel(RazorPagesMedicalCenter.Models.RazorPagesMedicalCenterContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; }
        // added for searching
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Cities { get; set; }

        [BindProperty(SupportsGet = true)]
        public string PatientCity { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of cities.
            IQueryable<string> cityQuery = from m in _context.Patient
                                            orderby m.PatientCity
                                            select m.PatientCity;
            var patients = from p in _context.Patient
                         select p;

            if (!string.IsNullOrEmpty(SearchString))
            { //change it up maybe to do a search based on not only last name but other stuff too
                patients = patients.Where(s => s.PatientLName.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(PatientCity))
            {
                patients = patients.Where(x => x.PatientCity == PatientCity);
            }

            Cities = new SelectList(await cityQuery.Distinct().ToListAsync());
            Patient = await patients.ToListAsync();
            //Patient = await _context.Patient.ToListAsync(); //this is the default await
        }
    }
}
