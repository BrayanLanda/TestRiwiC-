using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Type { get; set; }
        public string EnigeNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public List<Driver> Owner { get; set; } //= new List<Driver>();

        //Constructor
        public Vehicle(int id, string placa, string type, string enigeNumber, string serialNumber, byte peopleCapacity)
        {
            Id = id;
            Placa = placa;
            Type = type;
            EnigeNumber = enigeNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = new List<Driver>();
        }

        //Method mostrar detalles
        public void ShowDetails()
        {
            System.Console.WriteLine($"Id: {Id}");
            System.Console.WriteLine($"Placa: {Placa}");
            System.Console.WriteLine($"Tipo: {Type}");
            System.Console.WriteLine($"Número de Enigie: {EnigeNumber}");
            System.Console.WriteLine($"Número de Serie: {SerialNumber}");
            System.Console.WriteLine($"Capacidad de personas: {PeopleCapacity}");
            
        }

        //Methods para encontrar y eliminar un vehiculo
        // public int FindVehiculeById(int id)
        // {
        //     return 
        // }
        // public void DeleteVehicle(int id)
        // {
            
        // }
    }
}