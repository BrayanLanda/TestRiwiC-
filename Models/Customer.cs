using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class Customer : User
    {
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        //Constructor
        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateTime birthDate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : base (name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }

        public override void SetShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Membership Level: {MembershipLevel}");
            Console.WriteLine($"Preferred Payment Method: {PreferredPaymentMethod}");
        }

        //Methods de la clase
        public void UpdateMembershipLevel(string newMembershipLevel)
        {
            MembershipLevel = newMembershipLevel;
        }
    }
}