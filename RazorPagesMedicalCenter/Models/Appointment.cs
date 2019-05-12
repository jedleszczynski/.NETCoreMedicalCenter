using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMedicalCenter.Models
{
    public class Appointment
    {
        //To each foreign key I added a
        //so called "navigation proparty" that is
        //required by Entity Framework to recognize
        //relationship between models
        //More here:https://docs.microsoft.com/en-us/ef/core/modeling/relationships
        
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int ReferralID { get; set; }
        public Referral Referral { get; set; }
        public int MedProcedureID { get; set; }
        public ICollection<MedProcedure> MedProcedures { get; set; }
        public decimal AppointmentPrice { get; set; }


    }
}
