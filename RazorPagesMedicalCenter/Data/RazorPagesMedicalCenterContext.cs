using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMedicalCenter.Models
{
    public class RazorPagesMedicalCenterContext : DbContext
    {
        public RazorPagesMedicalCenterContext (DbContextOptions<RazorPagesMedicalCenterContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMedicalCenter.Models.Patient> Patient { get; set; }
    }
}
