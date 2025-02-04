using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class User
    {
        //Atributos
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }

        //Constructor
        public User(string name, string lastName, string typeDocument, string indentificationNumber, DateOnly birthDate, string email, string phoneNumber, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = indentificationNumber;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Method para calcular Edad
        protected int CalculateAge()
        {
            int Age = DateTime.Today.Year - BirthDate.Year;
            if (DateTime.Today.Month < BirthDate.Month || (DateTime.Today.Month == BirthDate.Month && DateTime.Today.Day < BirthDate.Day))
            {
                Age--;
            }
            return Age;
        }
        //Method para mostrar edad
        public int GetAge()
        {
            return CalculateAge();
        }

        //Method para mostrar informacion
        protected void ShowDetails()
        {
            System.Console.WriteLine($"Id: {Id}");
            System.Console.WriteLine($"Name: {Name} {LastName}");
            System.Console.WriteLine($"Document: {TypeDocument}-{IdentificationNumber}");
            System.Console.WriteLine($"Age: {GetAge()}");
            System.Console.WriteLine($"Email: {Email}");
            System.Console.WriteLine($"Phone: {PhoneNumber}");
            System.Console.WriteLine($"Address: {Address}");
        }

        public virtual void SetShowDetails()
        {
            ShowDetails();
        }
        
        //Setting and getting
        public void SetId(Guid id)
        {
            Id = id;
        }
        public Guid GetId()
        {
            return Id;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public void SetTypeDocument(string typeDocument)
        {
            TypeDocument = typeDocument;
        }
        public string GetTypeDocument()
        {
            return TypeDocument;
        }
        public void SetIdentificationNumber(string identificationNumber)
        {
            IdentificationNumber = identificationNumber;
        }
        public string GetIdentificationNumber()
        {
            return IdentificationNumber;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
        public string GetAddress()
        {
            return Address;
        }

    }
}