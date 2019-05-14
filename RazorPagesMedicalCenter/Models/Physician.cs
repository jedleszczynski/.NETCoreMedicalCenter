using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMedicalCenter.Models
{
    public class Physician
    {
        public int PhysicianID { get; set; }
        public string PhysicianFName { get; set; }
        public string PhysicianLName { get; set; }
        public ICollection<MedProcedure> MedProcedures { get; set; }

    }
}
