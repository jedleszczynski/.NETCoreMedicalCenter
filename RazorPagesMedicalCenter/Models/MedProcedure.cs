using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMedicalCenter.Models
{
    public class MedProcedure
    {
        public int MedProcedureID { get; set; }
        public string MedProcedureType { get; set; }
        public string MedProcedureName { get; set; }
        public int PhysicianID { get; set; }
        public Physician Physician { get; set; }

    }
}
