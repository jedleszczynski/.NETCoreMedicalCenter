using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMedicalCenter.Models;

namespace RazorPagesMedicalCenter.Models
{
    public class RazorPagesMedicalCenterContext : DbContext
    {
        public RazorPagesMedicalCenterContext (DbContextOptions<RazorPagesMedicalCenterContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMedicalCenter.Models.Patient> Patient { get; set; }

        public DbSet<RazorPagesMedicalCenter.Models.Appointment> Appointment { get; set; }

        public DbSet<RazorPagesMedicalCenter.Models.Physician> Physician { get; set; }

        public DbSet<RazorPagesMedicalCenter.Models.Referral> Referral { get; set; }

        public DbSet<RazorPagesMedicalCenter.Models.MedProcedure> MedProcedure { get; set; }
    }
}
