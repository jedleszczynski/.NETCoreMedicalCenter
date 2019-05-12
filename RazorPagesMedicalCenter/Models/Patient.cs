using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMedicalCenter.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        public string PatientFName { get; set; }

        public string PatientLName { get; set; }

        //public bool PatientIsClinical { get; set; }//  does this patient have histry in clinical research

        public string PatientZIP { get; set; }

        public string PatientStreet { get; set; }

        public string PatientCity { get; set; }

        public string PatientPhoneNum { get; set; }

        public string PatientEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime PatientDateOfBirth { get; set; }

        public string PatientFullInfo
        {
            get
            {//             Tom             Kipp        53217       Milwaukee 
                return $"{PatientFName} {PatientLName} {PatientZIP} {PatientCity} ";
            }
        }
    }
}
