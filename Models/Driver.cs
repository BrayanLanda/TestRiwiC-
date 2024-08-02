using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }

        //Constructor
        public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base (name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        //Mostrar informacion
        public override void SetShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"License Number: {LicenseNumber} and License Category: {LicenseCategory}");
            Console.WriteLine($"Driving Experience: {DrivingExperience} years");
        }

        public void UpdateLicenseCategory(string newCategory)
        {
            LicenseCategory = newCategory;
        }

        public void AddExperience(int years)
        {
            DrivingExperience += years;
        }
    }
}