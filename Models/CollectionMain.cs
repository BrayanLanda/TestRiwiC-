using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class CollectionMain
    {
        public List<Customer> customers { get; set; } = new List<Customer>();
        public List<Driver> drivers { get; set; } = new List<Driver>();
        public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();

        //Methods de la clase

        //Methods de agragar
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        //Methods de mostrar
        public void ShowCustomers()
        {
            foreach(var customer in customers)
            {
                customer.SetShowDetails();
                System.Console.WriteLine();
            }
        }
        public void ShowDrivers()
        {
            foreach(var driver in drivers)
            {
                driver.SetShowDetails();
                System.Console.WriteLine();
            }
        }
        public void ShowVehicle()
        {
            foreach(var vehicle in vehicles)
            {
                vehicle.ShowDetails();
                System.Console.WriteLine();
            }
        }

        //Queries
        public List<Driver> GetDriverOlderThan30()
        {
            return drivers.Where(s => s.GetAge() > 30).ToList();
        }
        public List<Customer> GetCustomerOlderThan30()
        {
            return customers.Where(s => s.GetAge() > 30).ToList();
        }

        public List<Customer> GetCustomersPayWithCard()
        {
            return customers.Where(c => c.PreferredPaymentMethod == "tarjeta de credito").ToList();
        }
    }
}