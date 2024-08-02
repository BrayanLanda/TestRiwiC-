using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Models;

namespace TransRiwi.Views
{
    public class ViewConsole
    {
        //Vistas para el usuario
        public int ShowMainManu()
        {
            System.Console.Clear();
            Console.WriteLine("=== Sistema de Transporte Riwi ===");
            Console.WriteLine("1. Gestionar Conductor");
            Console.WriteLine("2. Gestionar Cliente");
            Console.WriteLine("3. Gestionar Vehiculo");
            Console.WriteLine("4. Realizar Consultas");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowDriverMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Conductores ===");
            Console.WriteLine("1. Agregar Condutor");
            Console.WriteLine("2. Editar Condutor");
            Console.WriteLine("3. Eliminar Condutor");
            Console.WriteLine("4. Mostrar Condutores");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Clientes ===");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Editar Cliente");
            Console.WriteLine("3. Eliminar Cliente");
            Console.WriteLine("4. Mostrar Clientes");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowVehicleMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Vehiculos ===");
            Console.WriteLine("1. Agregar Vehiculo");
            Console.WriteLine("2. Editar Vehiculo");
            Console.WriteLine("3. Eliminar Vehiculo");
            Console.WriteLine("4. Mostrar Vehiculos");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                System.Console.Write("Invalid Option, Try Again: ");
            }
            return opcion;
        }

        public int ShowQueryMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Consultas ===");
            Console.WriteLine("1. Todos los usuarios que tiene mas de 30 años");
            Console.WriteLine("2. Ordenar Conductores por experiencia de conducion");
            Console.WriteLine("3. Clientes que prefieren pagar con tarjeta de credito");
            Console.WriteLine("4. Todos los condictores con licencia 'A2'");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
            {
                Console.Write("Opción inválida. Intente de nuevo: ");
            }
            return option;
        }

        public Customer GetCustomerInfo(Customer customer = null)
        {
            Console.Clear();
            System.Console.WriteLine(customer == null ? "==== Agregar un nuevo customer ====" : "==== Editar un customer ====");

            System.Console.Write("Nombre: ");
            string name = Console.ReadLine();

            System.Console.Write("Apellido: ");
            string lastName = Console.ReadLine();

            System.Console.Write("Tipo de Documento: ");
            string documentType = Console.ReadLine();
            
            System.Console.Write("Numero de Documento: ");
            string documentNumber = Console.ReadLine();
          
            System.Console.Write("Fecha de Nacimiento (YYYY-MM-DD): ");
            DateOnly hireDate;
            while(!DateOnly.TryParse(Console.ReadLine(), out hireDate))
            {
                System.Console.Write("Formato invalido. Intente de nuevo (YYYY-MM-DD): ");
            }

            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            System.Console.Write("Telefono: ");
            string phone = Console.ReadLine();

            System.Console.Write("Direccion: ");
            string address = Console.ReadLine();

            System.Console.Write("Nivel de afilacion: ");
            string membershipLevel = Console.ReadLine();

            System.Console.Write("Metodo preferido de pago: ");
            string preferredPaymentMethod = Console.ReadLine();

            if(customer == null)
            {
                return new Customer(name, lastName, documentType, documentNumber,hireDate, email, phone, address, membershipLevel, preferredPaymentMethod);
            }
            else
            {
                //Actualizar datos del customer existente
                customer.SetName(name);
                customer.SetLastName(lastName);
                customer.SetTypeDocument(documentType);
                customer.SetIdentificationNumber(documentNumber);
                customer.SetEmail(email);
                customer.SetPhoneNumber(phone);
                customer.SetAddress(address);
                customer.MembershipLevel = membershipLevel;
                customer.PreferredPaymentMethod = preferredPaymentMethod;

                return customer;
            }
        }

        public Driver GetDriverInfo(Driver driver = null)
        {
            Console.Clear();
            System.Console.WriteLine(driver == null ? "==== Agregar un nuevo driver ====" : "==== Editar un driver ====");

            System.Console.Write("Nombre: ");
            string name = Console.ReadLine();

            System.Console.Write("Apellido: ");
            string lastName = Console.ReadLine();

            System.Console.Write("Tipo de Documento: ");
            string documentType = Console.ReadLine();
            
            System.Console.Write("Numero de Documento: ");
            string documentNumber = Console.ReadLine();
          
            System.Console.Write("Fecha de nacimiento (YYYY-MM-DD): ");
            DateOnly hireDate;
            while(!DateOnly.TryParse(Console.ReadLine(), out hireDate))
            {
                System.Console.Write("Formato invalido. Intente de nuevo (YYYY-MM-DD): ");
            }

            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            System.Console.Write("Telefono: ");
            string phone = Console.ReadLine();

            System.Console.Write("Direccion: ");
            string address = Console.ReadLine();

            System.Console.Write("Numero de licencia: ");
            string licenseNumber = Console.ReadLine();

            System.Console.Write("Categoria de licencia: ");
            string licenseCategory = Console.ReadLine();

            System.Console.Write("Experiencia Manejando (YYYY): ");
            int drivingExperience;
            while(!int.TryParse(Console.ReadLine(), out drivingExperience))
            {
                System.Console.Write("Formato invalido. Intente de nuevo: ");
            }

            if(driver == null)
            {
                return new Driver(name, lastName, documentType, documentNumber,hireDate, email, phone, address, licenseNumber, licenseCategory, drivingExperience);
            }
            else
            {
                //Actualizar datos del driver existente
                driver.SetName(name);
                driver.SetLastName(lastName);
                driver.SetTypeDocument(documentType);
                driver.SetIdentificationNumber(documentNumber);
                driver.SetEmail(email);
                driver.SetPhoneNumber(phone);
                driver.SetAddress(address);
                driver.LicenseNumber = licenseNumber;
                driver.LicenseCategory = licenseCategory;
                driver.DrivingExperience = drivingExperience;

                return driver;
            }
        }

        //Solicitar un id para editar o eliminar
        public Guid GetIdForAction(string action)
        {
            System.Console.Write($"Ingresa el id del registro a {action}: ");
            Guid id;
            while (!Guid.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Id invalido. Intente de nuevo: ");
            }
            return id;
        }

        //Monstrar mensaje y esperar confirmacion del usuario
        public void ShowMessage(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            System.Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}