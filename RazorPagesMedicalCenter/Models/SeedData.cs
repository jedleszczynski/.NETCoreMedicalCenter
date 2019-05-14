using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesMedicalCenter.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMedicalCenterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMedicalCenterContext>>()))
            {
                //Initialize only runs if database is empty
                
                // Look for any Patients.
                if (context.Patient.Any())
                {
                    return;   // DB has been seeded
                }


                context.Patient.AddRange(
                    new Patient
                    {
                        PatientFName = "Adam",

                        PatientLName = "Popovic",

                        PatientIsClinical = false,

                        PatientDateOfBirth = DateTime.Parse("1996-7-26"),

                        PatientZIP = "26235",

                        PatientStreet = "6049 Troll Street",

                        PatientCity = "Poznan",

                        PatientPhoneNum = "6633322252",

                        PatientEmail = "adam.popovic@example.com",
                    },

                    new Patient
                    {
                        PatientFName = "Peter",

                        PatientLName = "Petrol",

                        PatientIsClinical = false,

                        PatientDateOfBirth = DateTime.Parse("1996-7-26"),

                        PatientZIP = "111111",

                        PatientStreet = "1232 Jones Street",

                        PatientCity = "Poznan",

                        PatientPhoneNum = "6633322252",

                        PatientEmail = "peterpetrol@example.com",
                    },

                    new Patient
                    {
                        PatientFName = "Greg",

                        PatientLName = "Kowalski",

                        PatientIsClinical = false,

                        PatientDateOfBirth = DateTime.Parse("1986-7-26"),

                        PatientZIP = "26235",

                        PatientStreet = "6049 Troll Street",

                        PatientCity = "Warsaw",

                        PatientPhoneNum = "6633322252",

                        PatientEmail = "gregkowalski@example.com",
                    },

                    new Patient
                    {
                        PatientFName = "Mike",

                        PatientLName = "Jones",

                        PatientIsClinical = true,

                        PatientDateOfBirth = DateTime.Parse("1932-2-11"),

                        PatientZIP = "26235",

                        PatientStreet = "6049 Troll Street",

                        PatientCity = "Poznan",

                        PatientPhoneNum = "6633322252",

                        PatientEmail = "mike.popovic@example.com",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}